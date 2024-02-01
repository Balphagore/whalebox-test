namespace WhaleBoxTest.UI
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;

    public abstract class UIButton : MonoBehaviour
    {
        [SerializeField]
        protected RectTransform     _body;
        [SerializeField]
        protected Button            _button;

        public Action               OnButtonClickedEvent;

        protected void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        protected void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClick);
        }

        public virtual void OnButtonClick()
        {
            OnButtonClickedEvent?.Invoke();
        }
    }
}
