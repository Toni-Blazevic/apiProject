using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.Reservation
{
    public record CreateReservationDto(int UserId, int? TerrainId, DateTime StartTime, DateTime EndTime, decimal TotalPrice);
}
