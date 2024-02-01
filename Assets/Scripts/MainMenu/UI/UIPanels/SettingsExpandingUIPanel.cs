namespace WhaleBoxTest.MainMenu.UI
{
    using Zenject;
    using UnityEngine;

    using WhaleBoxTest.UI;

    public class SettingsExpandingUIPanel : ExpandingUIPanel
    {
        [Inject]
        private UIController    _uiController;

        [SerializeField]
        private ToggleUIButton  _soundToggleUIButton;

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

        public void SetSoundValue(bool isDisabled)
        {
            _soundToggleUIButton.SetButtonValue(isDisabled);
        }

        private void UpdateListeners(bool isSubscribe)
        {
            if (isSubscribe)
            {
                _soundToggleUIButton.ButtonClickedEvent += OnButtonClickedEvent;
            }
            else
            {
                _soundToggleUIButton.ButtonClickedEvent -= OnButtonClickedEvent;
            }
        }

        private void OnButtonClickedEvent(bool IsSoundActive)
        {
            _uiController.SetSoundValue(IsSoundActive);
        }
    }
}
