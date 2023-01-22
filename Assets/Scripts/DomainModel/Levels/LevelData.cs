using System;
using Presentation.Levels;
using UnityEngine;

namespace DomainModel.Levels
{
    [Serializable]
    public class LevelData
    {
        [SerializeField] private LevelView _levelViewPrefab;
        [SerializeField ]private LevelType _levelType;
        [SerializeField] private int _index;
        private bool _isCompleted;

        public int Index => _index;
        public bool IsCompleted => _isCompleted;
        public LevelType LevelType => _levelType;
        public LevelView LevelViewPrefab => _levelViewPrefab;

        public event Action<LevelData> LevelFinished;
        public event Action<LevelData> LevelFailed;

        public void MarkAsCompleted()
        {
            _isCompleted = true;
        }
    }
}