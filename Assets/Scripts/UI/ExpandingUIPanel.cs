namespace WhaleBoxTest.UI
{
    using UnityEngine;
    using DG.Tweening;

    public class ExpandingUIPanel : UIPanel
    {
        [SerializeField]
        private float _expandDuration = 0.25f;

        private void Awake()
        {
            _body.localScale = Vector3.zero;
        }

        public override void Show()
        {
            base.Show();
            _body.DOScale(1f, _expandDuration);
        }

        public override void Hide()
        {
            _body.DOScale(0f, _expandDuration)
                .OnComplete(() => base.Hide());
        }
    }
}
