namespace WhaleBoxTest.Game.PlayerCamera
{
    using UnityEngine;

    using MVCCArchitecture;

    public class PlayerCameraView : ViewBase<PlayerCameraModel, PlayerCameraView, PlayerCameraController, PlayerCameraConfiguration>
    {
        [SerializeField]
        private Camera _playerCamera;

        public void SetCameraPosition(Vector2 position)
        {
            _playerCamera.transform.position = position;
        }
    }
}
