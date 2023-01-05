using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "MapConfigurations", menuName = "Configurations/MapConfigurations")]
    public class MapConfigurations : ScriptableObject
    {
        [SerializeField] private int _rows;
        [SerializeField] private int _columns;
        [SerializeField] private Vector3 _firstCellPosition;
        [SerializeField] private int _firstUnitsColumn;
        [SerializeField] private int _secondUnitsColumn;
        [SerializeField] private int _finishColumn;

        public int Rows => _rows;
        public int Columns => _columns;
        public Vector3 FirstCellPosition => _firstCellPosition;
        public int FirstUnitsColumn => _firstUnitsColumn;
        public int SecondUnitsColumn => _secondUnitsColumn;
        public int FinishColumn => _finishColumn;
    }
}