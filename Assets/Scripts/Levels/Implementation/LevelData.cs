using System;
using UnityEngine;

namespace Levels.Implementation
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

        public void MarkAsCompleted()
        {
            _isCompleted = true;
        }
    }
}