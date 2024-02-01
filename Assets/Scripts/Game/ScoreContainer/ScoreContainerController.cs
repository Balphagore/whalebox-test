namespace WhaleBoxTest.Game.ScoreContainer
{
    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Game.UI;
    using WhaleBoxTest.Universal.DataLoader;

    public class ScoreContainerController : ControllerBase<ScoreContainerModel, ScoreContainerView, ScoreContainerController, ScoreContainerConfiguration>,
        IInitializable
    {
        [Inject]
        private UIController            _uiController;
        [Inject]
        private DataLoaderController    _dataLoaderController;

        public void Initialize()
        {
            _dataLoaderController.DataLoadedEvent += OnDataLoadedEvent;
        }

        ~ScoreContainerController() 
        {
            _dataLoaderController.DataLoadedEvent -= OnDataLoadedEvent;
        }

        public void AddScore(int value)
        {
            model.AddScore(value);
            _uiController.SetScoreText(model.GetScore().ToString());
        }

        public void UpdateRecord(int newRecord)
        {
            _dataLoaderController.UpdateRecord(newRecord);
        }

        private void OnDataLoadedEvent(GameDataModel gameData)
        {
            model.SetRecord(gameData.Record);
        }
    }
}
