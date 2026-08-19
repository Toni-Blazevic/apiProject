using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.Terrain
{
    public record TerrainWithNoSportCentar(string Name, int SportTypeId, int PriceByHour, bool IsInDoor);
}
