using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.Review
{
    public record CreateReviewDto(int UserId, int? TerrainId, int Rating, string Comment, DateTime CreatedAt);
}
