namespace WhaleBoxTest.MainMenu.UI
{
    using UnityEngine;

    using MVCCArchitecture;

    using WhaleBoxTest.UI;

    public class UIView : ViewBase<UIModel, UIView, UIController, UIConfiguration>
    {
        [SerializeField]
        private UIPanel _scoreUIPanel;
        [SerializeField]
        private UIPanel _settingsUIPanel;

        protected override void Awake()
        {
            base.Awake();
            Application.targetFrameRate = 60;
        }

        public void SetScroreUIPanel(bool isActive)
        {
            if (isActive)
            {
                _scoreUIPanel.Show();
            }
            else
            {
                _scoreUIPanel.Hide();
            }
        }

        public void SetScorePanelScoreValue(string scoreValue)
        {
            ( _scoreUIPanel as ScoreExpandingUIPanel ).SetScoreValue(scoreValue);
        }

        public void SetSettingsPanelSoundValue(bool isDisabled)
        {
            (_settingsUIPanel as SettingsExpandingUIPanel).SetSoundValue(isDisabled);
        }

        public void SetSettingsUIPanel(bool isActive)
        {
            if (isActive)
            {
                _settingsUIPanel.Show();
            }
            else
            {
                _settingsUIPanel.Hide();
            }
        }
    }
}
