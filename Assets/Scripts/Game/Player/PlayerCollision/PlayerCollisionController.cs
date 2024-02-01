namespace WhaleBoxTest.Game.PlayerCollision
{
    using Zenject;
    using MVCCArchitecture;

    using WhaleBoxTest.Game.UI;
    using WhaleBoxTest.Game.ScoreContainer;

    public class PlayerCollisionController : ControllerBase<PlayerCollisionModel, PlayerCollisionView, PlayerCollisionController, PlayerCollisionConfiguration>
    {
        [Inject]
        private UIController _uIController;
        [Inject]
        private ScoreContainerController _scoreContainerController;

        public void DefeatCollision()
        {
            _uIController.OpenDefeatPanel();
        }

        public void ScoreCollision()
        {
            _scoreContainerController.AddScore(1);
        }
    }
}
