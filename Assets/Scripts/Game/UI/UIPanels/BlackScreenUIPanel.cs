namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;
    using UnityEngine.UI;
    using DG.Tweening;

    using WhaleBoxTest.UI;

    public class BlackScreenUIPanel : UIPanel
    {
        [SerializeField]
        private Image _image;
        [SerializeField]
        private float _showDuration = 1f;
        [SerializeField]
        private Color _fadeColor = new Color(0, 0, 0, 0.75f);

        public override void Show()
        {
            base.Show();
            _image.DOColor(_fadeColor, _showDuration);
        }

        public override void Hide()
        {
            Color newColor = _fadeColor;
            newColor.a = 0;
            _image.DOColor(newColor, _showDuration)
                .OnComplete(() => base.Hide());
        }
    }
}
