namespace WhaleBoxTest.Game.UI
{
    using System;

    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Universal.SceneLoader;
    using WhaleBoxTest.Universal.DataLoader;

    public class UIController : ControllerBase<UIModel, UIView, UIController, UIConfiguration>,
        IInitializable
    {
        [Inject]
        private SceneLoaderController   _sceneLoaderController;
        [Inject]
        private DataLoaderController    _dataLoaderController;

        public Action                   GamePausedEvent;
        public Action                   GameResumedEvent;

        public void Initialize()
        {
            _dataLoaderController.DataLoadedEvent += OnDataLoadedEvent;
        }

        ~UIController()
        {
            _dataLoaderController.DataLoadedEvent -= OnDataLoadedEvent;
        }

        private void OnDataLoadedEvent(GameDataModel gameData)
        {
            view.SetRecordText(gameData.Record.ToString());
        }

        public void OpenPausePanel()
        {
            GamePausedEvent?.Invoke();
            view.SetBlackScreenUIPanel(true);
            view.SetPauseUIPanel(true);
        }

        public void ClosePausePanel()
        {
            GameResumedEvent?.Invoke();
            view.SetBlackScreenUIPanel(false);
        }

        public void OpenDefeatPanel()
        {
            GamePausedEvent?.Invoke();
            view.SetDefeatUIPanel(true);
        }

        public void SetScoreText(string text)
        {
            view.SetScoreText(text);
        }

        public void QuitGame()
        {
            _sceneLoaderController.LoadMainMenuScene();
        }
    }
}
