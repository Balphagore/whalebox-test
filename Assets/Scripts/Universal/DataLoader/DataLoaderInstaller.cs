namespace WhaleBoxTest.Universal.DataLoader
{
    using Zenject;

    public class DataLoaderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<DataLoaderController>().AsSingle();
        }
    }
}