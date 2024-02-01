namespace WhaleBoxTest.Universal.SceneLoader
{
    using UnityEngine;

    using MVCCArchitecture;


    [CreateAssetMenu(fileName = "SceneLoaderConfiguration", menuName = "Data/Configurations/Universal/SceneLoaderConfiguration")]
    public class SceneLoaderConfiguration : ConfigurationBase<SceneLoaderModel, SceneLoaderView, SceneLoaderController, SceneLoaderConfiguration>
    {
        public string GameSceneId = "Game";
        public string MainMenuSceneId = "MainMenu";
    }
}
