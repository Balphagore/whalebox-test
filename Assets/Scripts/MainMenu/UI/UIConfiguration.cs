namespace WhaleBoxTest.MainMenu.UI
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "UIConfiguration", menuName = "Data/Configurations/MainMenu/UIConfiguration")]
    public class UIConfiguration : ConfigurationBase<UIModel, UIView, UIController, UIConfiguration>
    {

    }
}
