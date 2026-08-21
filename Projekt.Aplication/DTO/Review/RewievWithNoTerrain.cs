using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.Review
{
    public record RewievWithNoTerrain(int UserId, int Rating, string Comment, DateTime CreatedAt);
    
}
