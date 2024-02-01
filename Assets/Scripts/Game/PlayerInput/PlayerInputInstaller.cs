namespace WhaleBoxTest.Game.PlayerInput
{
    using Zenject;

    public class PlayerInputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerInputController>().AsSingle();
        }
    }
}