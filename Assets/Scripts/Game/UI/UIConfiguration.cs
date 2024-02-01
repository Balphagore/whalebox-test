namespace WhaleBoxTest.Game.UI
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "UIConfiguration", menuName = "Data/Configurations/Game/UIConfiguration")]
    public class UIConfiguration : ConfigurationBase<UIModel, UIView, UIController, UIConfiguration>
    {

    }
}
