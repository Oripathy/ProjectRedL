using System;
using UnityEngine;

namespace Presentation.Map.Cells
{
    public class MapCellView : View, IPoolableObj
    {
        [SerializeField] private MeshRenderer _meshRenderer;

        public Vector3 Size => _meshRenderer.bounds.size;
        
        public void SetActive(bool isActive)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(Vector3 position)
        {
            throw new NotImplementedException();
        }
    }
}