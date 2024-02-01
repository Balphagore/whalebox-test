namespace WhaleBoxTest.MainMenu.UI
{
    using UnityEngine;
    using WhaleBoxTest.UI;

    public class ScoreExpandingUIPanel : ExpandingUIPanel
    {
        [SerializeField]
        private UIIndicator _scoreUIIndicator;

        public void SetScoreValue(string value)
        {
            _scoreUIIndicator.SetText(value);
        }
    }
}
