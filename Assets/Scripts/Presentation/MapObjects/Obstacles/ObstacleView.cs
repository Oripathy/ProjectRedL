using UnityEngine;

namespace Presentation.MapObjects.Obstacles
{
    public class ObstacleView : View
    {
        [SerializeField] private MeshRenderer _meshRenderer;

        public Vector3 Size => _meshRenderer.bounds.size;
    }
}