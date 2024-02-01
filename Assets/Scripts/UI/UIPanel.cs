namespace WhaleBoxTest.UI
{
    using UnityEngine;

    public abstract class UIPanel : MonoBehaviour
    {
        [SerializeField]
        protected RectTransform     _body;
        [SerializeField]
        protected UIButton          _closeButton;

        public virtual void OnEnable()
        {
            if (_closeButton != null)
            {
                _closeButton.OnButtonClickedEvent += Hide;
            }
        }

        public virtual void OnDisable()
        {
            if (_closeButton != null)
            {
                _closeButton.OnButtonClickedEvent -= Hide;
            }
        }

        public virtual void Show()
        {
            _body.gameObject.SetActive(true);
        }

        public virtual void Hide()
        {
            _body.gameObject.SetActive(false);
        }
    }
}
