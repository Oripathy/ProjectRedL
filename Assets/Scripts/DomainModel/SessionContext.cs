using DomainModel.Levels;
using DomainModel.MapObjects.Units;

namespace DomainModel
{
    public class SessionContext
    {
        public string SceneName { get; }
        public LevelData LevelData { get; } // TODO maybe replace just with level type and level index
        public UnitType FirstUnitType { get; }
        public UnitType SecondUnitType { get; }

        public SessionContext(string sceneName, LevelData levelData, UnitType firstUnitType, UnitType secondUnitType)
        {
            SceneName = sceneName;
            LevelData = levelData;
            FirstUnitType = firstUnitType;
            SecondUnitType = secondUnitType;
        }
    }
}