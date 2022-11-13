using Map.MapCells.Implementation;
using UnityEngine;

namespace Containers
{
    [CreateAssetMenu(fileName = "MapCellConfigurations", menuName = "Configurations/MapCellConfigurations")]
    public class MapCellConfigurations : ScriptableObject
    {
        [SerializeField] private MapCellView _mapCellPrefab;

        public MapCellView MapCellPrefab => _mapCellPrefab;
    }
}