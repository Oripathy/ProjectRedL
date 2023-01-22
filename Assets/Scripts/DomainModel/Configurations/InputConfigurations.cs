using UnityEngine;

namespace DomainModel.Configurations
{
    [CreateAssetMenu(fileName = "InputConfigurations", menuName = "Configurations/InputConfigurations")]
    public class InputConfigurations : ScriptableObject
    {
        [SerializeField] private int _unitLayer;
        [SerializeField] private float _minSwipeDelta;

        public int UnitLayerMask => 1 << _unitLayer;
        public float MinSwipeDelta => _minSwipeDelta;
    }
}