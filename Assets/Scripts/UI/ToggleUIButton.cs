namespace WhaleBoxTest.UI
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;

    public class ToggleUIButton : MonoBehaviour
    {
        [SerializeField]
        protected RectTransform     _bodyOn;
        [SerializeField]
        protected RectTransform     _bodyOff;
        [SerializeField]
        protected Button            _buttonOn;
        [SerializeField]
        protected Button            _buttonOff;

        public Action<bool>         ButtonClickedEvent;

        private void OnEnable()
        {
            _buttonOn.onClick.AddListener(OnButtonOnClick);
            _buttonOff.onClick.AddListener(OnButtonOffClick);
        }

        private void OnDisable()
        {
            _buttonOn.onClick.RemoveListener(OnButtonOnClick);
            _buttonOff.onClick.RemoveListener(OnButtonOffClick);
        }

        public void OnButtonOnClick()
        {
            ButtonClickedEvent?.Invoke(true);
            SetButtonValue(true);
        }

        public void OnButtonOffClick()
        {
            ButtonClickedEvent?.Invoke(false);
            SetButtonValue(false);
        }

        public void SetButtonValue(bool isDisabled)
        {
            _bodyOn.gameObject.SetActive(!isDisabled);
            _bodyOff.gameObject.SetActive(isDisabled);
        }
    }
}
