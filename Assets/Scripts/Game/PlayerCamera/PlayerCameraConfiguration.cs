namespace WhaleBoxTest.Game.PlayerCamera
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "PlayerCameraConfiguration", menuName = "Data/Configurations/PlayerCameraConfiguration")]
    public class PlayerCameraConfiguration : ConfigurationBase<PlayerCameraModel, PlayerCameraView, PlayerCameraController, PlayerCameraConfiguration>
    {
        
    }
}
