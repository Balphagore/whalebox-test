namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;

    using Zenject;

    using WhaleBoxTest.UI;

    public class DefeatExpandingUIPanel : ExpandingUIPanel
    {
        [Inject]
        private UIController    _uiController;

        [SerializeField]
        private UIButton        _quitButton;
        [SerializeField]
        private UIIndicator     _scoreUIIndicator;
        [SerializeField]
        private UIIndicator     _recordUIIndicator;

        public override void OnEnable()
        {
            base.OnEnable();
            UpdateListeners(true);
        }

        public override void OnDisable()
        {
            base.OnDisable();
            UpdateListeners(false);
        }

        public void SetScoreText(string text)
        {
            _scoreUIIndicator.SetText(text);
        }

        public void SetRecordText(string text)
        {
            _recordUIIndicator.SetText(text);
        }

        private void UpdateListeners(bool isSubscribe)
        {
            if (isSubscribe)
            {
                _quitButton.OnButtonClickedEvent += OnQuitButtonClickedEvent;
            }
            else
            {
                _quitButton.OnButtonClickedEvent -= OnQuitButtonClickedEvent;
            }
        }

        private void OnQuitButtonClickedEvent()
        {
            _uiController.QuitGame();
        }
    }
}
