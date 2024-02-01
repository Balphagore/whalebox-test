namespace WhaleBoxTest.UI
{
    using TMPro;
    using UnityEngine;

    public class UIIndicator : MonoBehaviour
    {
        [SerializeField]
        private RectTransform     _body;
        [SerializeField]
        private TextMeshProUGUI   _text;

        public void SetText(string text)
        {
            _text.text = text;
        }
    }
}
