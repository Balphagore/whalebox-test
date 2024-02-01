namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;
    using Zenject;

    using WhaleBoxTest.UI;

    public class MainUIPanel : UIPanel
    {
        [Inject]
        private UIController    _uiController;

        [SerializeField]
        private UIButton        _pauseButton;

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
                _pauseButton.OnButtonClickedEvent += OnPauseButtonClickedEvent;
            }
            else
            {
                _pauseButton.OnButtonClickedEvent -= OnPauseButtonClickedEvent;
            }
        }

        private void OnPauseButtonClickedEvent()
        {
            _uiController.OpenPausePanel();
        }
    }
}
