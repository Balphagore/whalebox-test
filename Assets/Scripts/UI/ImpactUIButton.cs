namespace WhaleBoxTest.UI
{
    using UnityEngine;
    using DG.Tweening;

    public class ImpactUIButton : UIButton
    {
        [SerializeField]
        private float       _impactDuration     = 0.25f;
        [SerializeField]
        private float       _impactStrength     = 0.9f;
        private bool        _isCooldown;

        public override void OnButtonClick()
        {
            if (!_isCooldown)
            {
                _isCooldown = true;

                _body.DOScale(_body.localScale * _impactStrength, _impactDuration)
                    .SetEase(Ease.InCirc)
                    .SetLoops(2, LoopType.Yoyo)
                    .OnComplete(() => 
                    { 
                        _isCooldown = false; 
                        base.OnButtonClick(); 
                    });
            }
        }
    }
}
