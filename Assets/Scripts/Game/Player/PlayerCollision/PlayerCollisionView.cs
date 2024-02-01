namespace WhaleBoxTest.Game.PlayerCollision
{
    using UnityEngine;

    using MVCCArchitecture;

    public class PlayerCollisionView : ViewBase<PlayerCollisionModel, PlayerCollisionView, PlayerCollisionController, PlayerCollisionConfiguration>
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == configuration.DefeatCollisionTag)
            {
                controller.DefeatCollision();
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            controller.ScoreCollision();
        }
    }
}
