namespace WhaleBoxTest.Game.PlayerCollision
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "PlayerCollisionConfiguration", menuName = "Data/Configurations/PlayerCollisionConfiguration")]
    public class PlayerCollisionConfiguration : ConfigurationBase<PlayerCollisionModel, PlayerCollisionView, PlayerCollisionController, PlayerCollisionConfiguration>
    {
        public string DefeatCollisionTag = "DefeatCollision";
    }
}
