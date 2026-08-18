using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Entities
{
    public class Terrain : BaseEntity
    {
        
        public string Name { get; set; }
        public int SportTypeId { get; set; }
        public SportType SportType { get; set; }
        public int SportCentarId { get; set; }
        public SportCentar SportCentar { get; set; }
        public int PriceByHour { get; set; }
        public bool IsInDoor { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
