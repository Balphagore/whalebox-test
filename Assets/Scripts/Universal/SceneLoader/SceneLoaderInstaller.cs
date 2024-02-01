namespace WhaleBoxTest.Universal.SceneLoader
{
    using Zenject;

    public class SceneLoaderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<SceneLoaderController>().AsSingle();
        }
    }
}