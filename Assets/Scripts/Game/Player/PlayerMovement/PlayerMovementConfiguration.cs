namespace WhaleBoxTest.Game.PlayerMovement
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "PlayerMovementConfiguration", menuName = "Data/Configurations/PlayerMovementConfiguration")]
    public class PlayerMovementConfiguration : ConfigurationBase<PlayerMovementModel, PlayerMovementView, PlayerMovementController, PlayerMovementConfiguration>
    {
        public float PlayerSpeed        = 100.0f;
        public float GravityStrength    = 9.81f;
        public float JumpStrength       = 5.0f;
    }
}
