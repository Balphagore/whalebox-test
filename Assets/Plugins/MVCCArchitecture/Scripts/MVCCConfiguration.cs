using UnityEditor;
using UnityEngine;

public class MVCCConfiguration : ScriptableObject
{
    public string Namespace;

#if UNITY_EDITOR
    private static MVCCConfiguration instance;

    public static MVCCConfiguration Instance
    {
        get
        {
            if (instance == null)
            {
                string[] guids = AssetDatabase.FindAssets("t:MVCCConfiguration");
                if (guids.Length > 0)
                {
                    string path = AssetDatabase.GUIDToAssetPath(guids[0]);
                    instance = AssetDatabase.LoadAssetAtPath<MVCCConfiguration>(path);
                }
            }
            return instance;
        }
    }

    public static string GetGlobalNamespace()
    {
        return Instance.Namespace;
    }
#endif
}
