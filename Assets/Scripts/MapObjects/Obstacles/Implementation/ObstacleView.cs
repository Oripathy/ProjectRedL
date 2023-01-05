using Base;
using UnityEngine;

namespace MapObjects.Obstacles.Implementation
{
    public class ObstacleView : View
    {
        [SerializeField] private MeshRenderer _meshRenderer;

        public Vector3 Size => _meshRenderer.bounds.size;
    }
}