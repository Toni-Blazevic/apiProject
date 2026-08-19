using Projekt.Aplication.DTO.Terrain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.SportCentar
{
    public record SportCentarWithTerrainsDto(string Name, string Addres, string City, string Description, ICollection<TerrainWithNoSportCentar> Terrains);
}
