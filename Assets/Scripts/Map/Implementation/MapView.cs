using System.Collections.Generic;
using Base;
using Map.MapCells.Implementation;
using UnityEngine;

namespace Map.Implementation
{
    public class MapView : View
    {
        [SerializeField] private List<MapCellView> _cells;
    }
}