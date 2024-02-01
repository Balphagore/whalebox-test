namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;
    using Zenject;

    using WhaleBoxTest.UI;

    public class PauseExpandingUIPanel : ExpandingUIPanel
    {
        [Inject]
        private UIController    _uiController;

        [SerializeField]
        private UIButton        _quitButton;
        [SerializeField]
        private UIIndicator     _scoreUIIndicator;

        public override void Hide()
        {
            base.Hide();
            _uiController.ClosePausePanel();
        }

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
