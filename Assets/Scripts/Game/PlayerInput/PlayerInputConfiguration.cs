namespace WhaleBoxTest.Game.PlayerInput
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "PlayerInputConfiguration", menuName = "Data/Configurations/PlayerInputConfiguration")]
    public class PlayerInputConfiguration : ConfigurationBase<PlayerInputModel, PlayerInputView, PlayerInputController, PlayerInputConfiguration>
    {
        
    }
}
