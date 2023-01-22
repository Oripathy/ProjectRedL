using UnityEngine;

namespace DomainModel.Configurations
{
    [CreateAssetMenu(fileName = "UnitsProviderConfigurations", menuName = "Configurations/UnitsProviderConfigurations")]
    public class UnitsProviderConfigurations : ScriptableObject
    {
        [SerializeField] private int _maxUnitsAmount;

        public int MaxUnitsAmount => _maxUnitsAmount;
    }
}