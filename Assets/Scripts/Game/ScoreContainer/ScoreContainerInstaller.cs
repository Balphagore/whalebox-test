namespace WhaleBoxTest.Game.ScoreContainer
{
    using Zenject;

    public class ScoreContainerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ScoreContainerController>().AsSingle();
        }
    }
}