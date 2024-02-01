namespace WhaleBoxTest.MainMenu.UI
{
    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Universal.DataLoader;
    using WhaleBoxTest.Universal.SceneLoader;
    using UnityEngine;

    public class UIController : ControllerBase<UIModel, UIView, UIController, UIConfiguration>,
        IInitializable
    {
        [Inject]
        private SceneLoaderController _sceneLoaderController;
        [Inject]
        private DataLoaderController _dataLoaderController;

        public void Initialize()
        {
            _dataLoaderController.DataLoadedEvent += OnDataLoadedEvent;
        }

        ~UIController()
        {
            _dataLoaderController.DataLoadedEvent -= OnDataLoadedEvent;
        }

        public void StartGame()
        {
            _sceneLoaderController.LoadGameScene();
        }

        public void OpenScorePanel()
        {
            view.SetScroreUIPanel(true);
        }

        public void OpenSettingsPanel()
        {
            view.SetSettingsUIPanel(true);
        }

        public void SetSoundValue(bool isDisabled)
        {
            _dataLoaderController.UpdateSoundValue(isDisabled);
        }

        public void OnDataLoadedEvent(GameDataModel gameDataModel)
        {
            view.SetScorePanelScoreValue(gameDataModel.Record.ToString());
            view.SetSettingsPanelSoundValue(gameDataModel.IsSoundDisabled);
        }
    }
}
