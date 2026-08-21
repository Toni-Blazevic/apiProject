using Projekt.Aplication.DTO.Review;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.Terrain
{
    public record TerrainWithReviews(string Name, int SportTypeId, int SportCentarId, int PriceByHour, bool IsInDoor, IEnumerable<RewievWithNoTerrain> Reviews);
   
}
