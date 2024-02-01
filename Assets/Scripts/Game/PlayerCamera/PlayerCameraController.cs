namespace WhaleBoxTest.Game.PlayerCamera
{
    using UnityEngine;

    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Game.PlayerMovement;

    public class PlayerCameraController : ControllerBase<PlayerCameraModel, PlayerCameraView, PlayerCameraController, PlayerCameraConfiguration>,
        IInitializable
    {
        [Inject]
        private PlayerMovementController _playerMovementController;

        public void Initialize()
        {
            _playerMovementController.PlayerPositionUpdatedEvent += OnPlayerPositionUpdatedEvent;
        }

        private void OnPlayerPositionUpdatedEvent(Vector2 position)
        {
            view.SetCameraPosition(new Vector2(position.x, 0));
        }

        ~PlayerCameraController()
        {
            _playerMovementController.PlayerPositionUpdatedEvent -= OnPlayerPositionUpdatedEvent;
        }
    }
}
