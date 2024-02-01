namespace WhaleBoxTest.Game.ScoreContainer
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "ScoreContainerConfiguration", menuName = "Data/Configurations/ScoreContainerConfiguration")]
    public class ScoreContainerConfiguration : ConfigurationBase<ScoreContainerModel, ScoreContainerView, ScoreContainerController, ScoreContainerConfiguration>
    {
        
    }
}
