using System;
using System.Collections.Generic;
using Levels.Implementation;
using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "LevelsConfigurations", menuName = "Configurations/LevelsConfigurations")]
    public class LevelsConfigurations : ScriptableObject
    {
        [SerializeField] private List<LevelData> _levelsData;

        public LevelData GetLevelDataWithIndex(int index)
        {
            if (index >= _levelsData.Count)
            {
                throw new IndexOutOfRangeException("Provided index is out of range");
            }

            return _levelsData[index];
        }

        public bool IsLevelWithIndexAvailable(int index)
        {
            return index < _levelsData.Count;
        }
    }
}