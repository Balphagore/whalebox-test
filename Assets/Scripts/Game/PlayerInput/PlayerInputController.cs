namespace WhaleBoxTest.Game.PlayerInput
{
    using System;
    using UnityEngine.InputSystem;

    using Zenject;
    using MVCCArchitecture;

    public class PlayerInputController : ControllerBase<PlayerInputModel, PlayerInputView, PlayerInputController, PlayerInputConfiguration>,
        IInitializable
    {
        private PlayerInputActions _playerInputActions;

        public Action JumpActionPerformedEvent;

        public void Initialize()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Enable();
            _playerInputActions.UniversalActionMap.Jump.performed += OnJump;
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            JumpActionPerformedEvent?.Invoke();
        }

        ~PlayerInputController()
        {
            _playerInputActions.UniversalActionMap.Jump.performed -= OnJump;
        }
    }
}
