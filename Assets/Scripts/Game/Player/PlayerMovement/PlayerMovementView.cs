namespace WhaleBoxTest.Game.PlayerMovement
{
    using UnityEngine;

    using MVCCArchitecture;

    public class PlayerMovementView : ViewBase<PlayerMovementModel, PlayerMovementView, PlayerMovementController, PlayerMovementConfiguration>
    {
        [SerializeField]
        private Rigidbody2D _rigidBody;

        public void SetVelocity(Vector2 velocity)
        {
            _rigidBody.velocity = velocity;
        }

        public Vector2 GetPlayerPosition()
        {
            return _rigidBody.position;
        }
    }
}
