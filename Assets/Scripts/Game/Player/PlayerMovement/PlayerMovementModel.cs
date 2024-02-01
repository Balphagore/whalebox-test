namespace WhaleBoxTest.Game.PlayerMovement
{
    using System;
    using UnityEngine;

    using MVCCArchitecture;

    [Serializable]
    public class PlayerMovementModel : ModelBase<PlayerMovementModel, PlayerMovementView, PlayerMovementController, PlayerMovementConfiguration>
    {
        private float   _currentGravity  = 0.0f;

        private bool    _isJumping;
        private bool    _isStopped;

        public void Jump()
        {
            _isJumping = true;
        }

        public void Stop()
        {
            _isStopped = true;
        }

        public void Resume() 
        { 
            _isStopped = false; 
        }

        public Vector2 GetVelocity()
        {
            if (!_isStopped)
            {
                if (_isJumping)
                {
                    _currentGravity = configuration.JumpStrength;
                    _isJumping = false;
                }

                _currentGravity -= configuration.GravityStrength * Time.fixedDeltaTime;
                return new Vector2(configuration.PlayerSpeed * Time.fixedDeltaTime, _currentGravity);
            }
            else
            {
                return Vector2.zero;
            }
        }
    }
}
