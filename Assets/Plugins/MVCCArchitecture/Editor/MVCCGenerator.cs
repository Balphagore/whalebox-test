namespace MVCCArchitecture
{
#if UNITY_EDITOR
    using System.IO;
    using UnityEditor;
    using UnityEngine;

    public class MVCCGenerator : EditorWindow
    {
        private string _namespace = "";
        private string _folderPath;
        private string _MVCCName;

        [MenuItem("Assets/Create/MVCC", false, 1)]
        private static void GetFolderPath()
        {
            string selectedPath = AssetDatabase.GetAssetPath(Selection.GetFiltered<Object>(SelectionMode.Assets)[0]);

            MVCCGenerator window = GetWindow<MVCCGenerator>();
            window._folderPath = selectedPath;
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("Selected Folder Path: " + _folderPath);

            GUILayout.Space(10);

            GUILayout.Label("Enter MVCC name:");
            _MVCCName = GUILayout.TextField(_MVCCName);

            GUILayout.Label("Enter namespace:");
            _namespace = GUILayout.TextField(_namespace);

            if (GUILayout.Button("Create"))
            {
                if(_namespace == "")
                {
                    Debug.LogWarning("!");
                    _namespace = MVCCConfiguration.GetGlobalNamespace();
                }
                string folderFullPath = Path.Combine(_folderPath, _MVCCName);

                if (!Directory.Exists(folderFullPath))
                {
                    Directory.CreateDirectory(folderFullPath);

                    CreateFile(_folderPath, _MVCCName, "Model");
                    CreateFile(_folderPath, _MVCCName, "View");
                    CreateFile(_folderPath, _MVCCName, "Controller");
                    CreateFile(_folderPath, _MVCCName, "Configuration");

                    AssetDatabase.Refresh();
                }
                else
                {
                    Debug.LogWarning("Folder already exists at: " + folderFullPath);
                }

                Close();
            }
        }

        private void CreateFile(string folderPath, string MVCName, string fileType)
        {
            string filePath = Path.Combine(folderPath, MVCName, MVCName + fileType + ".cs");
            string className = MVCName + fileType;

            if (!File.Exists(filePath))
            {
                string code = "namespace " + _namespace + "\n" +
                    "{\n" +
                    (fileType switch
                    { 
                        "Configuration" =>
                                "    using UnityEngine;\n\n" +
                                "    using MVCCArchitecture;\n\n" +
                                "    [CreateAssetMenu(fileName = \"" + MVCName + fileType + "\", menuName = \"Data/Configurations/" + MVCName + fileType + "\")]\n",
                        "Model" =>                                 
                                "    using System;\n\n" +
                                "    using MVCCArchitecture;\n\n" +
                                "    [Serializable]\n",
                        "View" => 
                                "    using MVCCArchitecture;\n\n",
                        "Controller" => 
                                "    using MVCCArchitecture;\n\n",
                        _ => ""
                    }) +
                    "    public class " + className + " : " + fileType + "Base<" +
                    MVCName + "Model, " +
                    MVCName + "View, " +
                    MVCName + "Controller, " +
                    MVCName + "Configuration" +
                    ">\n" +
                    "    {\n" +
                    "        \n" +
                    "    }\n" +
                    "}\n";

                File.WriteAllText(filePath, code);
            }
            else
            {
                Debug.LogWarning("File already exists at: " + filePath);
            }
        }
    }
#endif
}