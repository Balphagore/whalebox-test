namespace WhaleBoxTest.Game.PlayerMovement
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;

    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Game.PlayerInput;
    using WhaleBoxTest.Game.UI;

    public class PlayerMovementController : ControllerBase<PlayerMovementModel, PlayerMovementView, PlayerMovementController, PlayerMovementConfiguration>,
        IInitializable,
        IFixedTickable
    {
        [Inject]
        private PlayerInputController   _playerInputController;
        [Inject]
        private UIController            _uiController;

        public Action<Vector2>          PlayerPositionUpdatedEvent;

        public void Initialize()
        {
            _playerInputController.JumpActionPerformedEvent += OnJumpActionPerformedEvent;
            _uiController.GamePausedEvent += OnGamePausedEvent;
            _uiController.GameResumedEvent += OnGameResumedEvent;
        }

        ~PlayerMovementController()
        {
            _playerInputController.JumpActionPerformedEvent -= OnJumpActionPerformedEvent;
            _uiController.GamePausedEvent -= OnGamePausedEvent;
            _uiController.GameResumedEvent -= OnGameResumedEvent;
        }

        public void FixedTick()
        {

            PlayerPositionUpdatedEvent?.Invoke(view.GetPlayerPosition());
            view.SetVelocity(model.GetVelocity());
        }

        private void OnJumpActionPerformedEvent()
        {
            if (!IsPointerOverUIObject())
            {
                model.Jump();
            }
        }

        private void OnGamePausedEvent()
        {
            model.Stop();
        }

        private void OnGameResumedEvent()
        {
            model.Resume();
        }

        private bool IsPointerOverUIObject()
        {
            PointerEventData eventData = new PointerEventData(EventSystem.current);
            eventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, results);
            return results.Count > 0;
        }
    }
}
