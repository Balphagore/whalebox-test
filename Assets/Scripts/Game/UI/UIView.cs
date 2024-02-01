namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;

    using MVCCArchitecture;

    using WhaleBoxTest.UI;

    public class UIView : ViewBase<UIModel, UIView, UIController, UIConfiguration>
    {
        [SerializeField]
        private UIPanel         _pauseUIPanel;
        [SerializeField]
        private UIPanel         _blackScreenUIPanel;
        [SerializeField]
        private UIPanel         _defeatUIPanel;
        [SerializeField]
        private UIIndicator     _scoreUIIndicator;

        public void SetPauseUIPanel(bool isActive)
        {
            if (isActive)
            {
                _pauseUIPanel.Show();
            }
            else
            {
                _pauseUIPanel.Hide();
            }
        }

        public void SetBlackScreenUIPanel(bool isActive)
        {
            if (isActive)
            {
                _blackScreenUIPanel.Show();
            }
            else
            {
                _blackScreenUIPanel.Hide();
            }
        }

        public void SetDefeatUIPanel(bool isActive)
        {
            if (isActive)
            {
                _defeatUIPanel.Show();
            }
            else
            { 
                _defeatUIPanel.Hide();
            }
        }

        public void SetScoreText(string text)
        {
            _scoreUIIndicator.SetText(text);
            ( _defeatUIPanel as DefeatExpandingUIPanel ).SetScoreText(text);
        }

        public void SetRecordText(string text)
        {
            ( _defeatUIPanel as DefeatExpandingUIPanel ).SetRecordText(text);
        }
    }
}
