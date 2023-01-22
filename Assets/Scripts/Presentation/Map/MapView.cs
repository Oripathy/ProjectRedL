using System.Collections.Generic;
using Presentation.Map.Cells;
using UnityEngine;

namespace Presentation.Map
{
    public class MapView : View
    {
        [SerializeField] private List<MapCellView> _cells;
    }
}