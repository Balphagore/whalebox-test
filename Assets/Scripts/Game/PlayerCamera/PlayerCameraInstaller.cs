namespace WhaleBoxTest.Game.PlayerCamera
{
    using Zenject;

    public class PlayerCameraInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerCameraController>().AsSingle();
        }
    }
}