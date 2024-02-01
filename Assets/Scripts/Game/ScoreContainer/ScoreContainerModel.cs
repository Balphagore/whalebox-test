namespace WhaleBoxTest.Game.ScoreContainer
{
    using System;
    using UnityEngine;

    using MVCCArchitecture;

    [Serializable]
    public class ScoreContainerModel : ModelBase<ScoreContainerModel, ScoreContainerView, ScoreContainerController, ScoreContainerConfiguration>
    {
        [SerializeField]
        private int _score;
        [SerializeField]
        private int _record;

        public void SetRecord(int record)
        {
            _record = record;
        }

        public void AddScore(int value)
        {
            _score += value;
            if (_score > _record)
            {
                controller.UpdateRecord(_score);
            }
        }

        public int GetScore()
        {
            return _score;
        }

    }
}
