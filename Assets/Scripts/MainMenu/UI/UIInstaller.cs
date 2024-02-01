namespace WhaleBoxTest.MainMenu.UI
{
    using Zenject;

    public class UIInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<UIController>().AsSingle();
        }
    }
}