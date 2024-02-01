namespace WhaleBoxTest.MainMenu.UI
{
    using UnityEngine;
    using Zenject;

    using WhaleBoxTest.UI;

    public class MainUIPanel : UIPanel
    {
        [Inject]
        private UIController    _uiController;

        [SerializeField]
        private UIButton        _startButton;
        [SerializeField]
        private UIButton        _scoreButton;
        [SerializeField]
        private UIButton        _settingsButton;

        public override void OnEnable()
        {
            UpdateListeners(true);
        }

        public override void OnDisable()
        {
            UpdateListeners(false);
        }

        private void UpdateListeners(bool isSubscribe)
        {
            if (isSubscribe)
            {
                _startButton.OnButtonClickedEvent += OnStartGameButtonClickedEvent;
                _scoreButton.OnButtonClickedEvent += OnScoreButtonClickEvent;
                _settingsButton.OnButtonClickedEvent += OnSettingsButtonClickEvent;
            }
            else
            {
                _startButton.OnButtonClickedEvent -= OnStartGameButtonClickedEvent;
                _scoreButton.OnButtonClickedEvent -= OnScoreButtonClickEvent;
                _settingsButton.OnButtonClickedEvent -= OnSettingsButtonClickEvent;
            }
        }

        private void OnStartGameButtonClickedEvent()
        {
            _uiController.StartGame();
        }

        private void OnScoreButtonClickEvent()
        {
            _uiController.OpenScorePanel();
        }

        private void OnSettingsButtonClickEvent()
        {
            _uiController.OpenSettingsPanel();
        }
    }
}
