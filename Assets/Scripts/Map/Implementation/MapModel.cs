using System.Collections.Generic;
using Configurations;
using Map.MapCells.Implementation;

namespace Map.Implementation
{
    public class MapModel
    {
        private readonly MapConfigurations _configurations;
        private List<MapCellModel> _cells;

        public MapModel(MapConfigurations configurations)
        {
            _configurations = configurations;
        }
    }
}