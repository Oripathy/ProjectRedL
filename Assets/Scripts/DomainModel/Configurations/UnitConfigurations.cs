using Presentation.MapObjects.Units;
using UnityEngine;

namespace DomainModel.Configurations
{
    [CreateAssetMenu(fileName = "UnitConfigurations", menuName = "Configurations/UnitConfigurations")]
    public class UnitConfigurations : ScriptableObject
    {
        [SerializeField] private UnitView _unitPrefab;

        public UnitView UnitPrefab => _unitPrefab;
    }
}