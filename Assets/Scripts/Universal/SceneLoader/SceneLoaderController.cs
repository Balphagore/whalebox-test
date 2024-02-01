namespace WhaleBoxTest.Universal.SceneLoader
{
    using UnityEngine.SceneManagement;

    using MVCCArchitecture;

    public class SceneLoaderController : ControllerBase<SceneLoaderModel, SceneLoaderView, SceneLoaderController, SceneLoaderConfiguration>
    {
        public void LoadGameScene()
        {
            SceneManager.LoadScene(configuration.GameSceneId);
        }

        public void LoadMainMenuScene()
        {
            SceneManager.LoadScene(configuration.MainMenuSceneId);
        }
    }
}
