namespace WhaleBoxTest.Universal.DataLoader
{
    using System;
    using System.IO;
    using UnityEngine;

    using MVCCArchitecture;

    [Serializable]
    public class DataLoaderModel : ModelBase<DataLoaderModel, DataLoaderView, DataLoaderController, DataLoaderConfiguration>
    {
        [SerializeField]
        private GameDataModel _loadedData;

        public void LoadData()
        {
            string path = Path.Combine(Application.persistentDataPath, "GameData.json");
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                _loadedData = JsonUtility.FromJson<GameDataModel>(json);
            }
            else
            {
                GameDataModel gameData = new();
                File.WriteAllText(path, JsonUtility.ToJson(gameData));
                _loadedData = gameData;
            }
        }

        public void UpdateRecord(int newRecord)
        {
            _loadedData.Record = newRecord;
            SaveData();
        }

        public void UpdateSoundValue(bool isDisabled)
        {
            _loadedData.IsSoundDisabled = isDisabled;
            SaveData();
        }

        public GameDataModel GetLoadedData()
        {
            return _loadedData;
        }

        private void SaveData()
        {
            string path = Path.Combine(Application.persistentDataPath, "GameData.json");
            File.WriteAllText(path, JsonUtility.ToJson(_loadedData));
        }
    }
}
