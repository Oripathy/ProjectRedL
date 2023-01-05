using MapObjects.Units.Implementation;
using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "UnitConfigurations", menuName = "Configurations/UnitConfigurations")]
    public class UnitConfigurations : ScriptableObject
    {
        [SerializeField] private UnitView _unitPrefab;

        public UnitView UnitPrefab => _unitPrefab;
    }
}