namespace WhaleBoxTest.Game.Player
{
    using Zenject;

    using WhaleBoxTest.Game.PlayerMovement;
    using WhaleBoxTest.Game.PlayerCollision;

    public class PlayerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerMovementController>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerCollisionController>().AsSingle();
        }
    }
}