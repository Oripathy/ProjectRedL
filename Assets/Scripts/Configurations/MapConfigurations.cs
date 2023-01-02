using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "MapConfigurations", menuName = "Configurations/MapConfigurations")]
    public class MapConfigurations : ScriptableObject
    {
        [SerializeField] private int _rows;
        [SerializeField] private int _columns;

        public int Rows => _rows;
        public int Columns => _columns;
    }
}