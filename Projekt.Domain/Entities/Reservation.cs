using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Entities
{
    public class Reservation : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int? TerrainId { get; set; }
        public Terrain? Terrain { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalPrice { get; set; }
        public Payment Payment {  get; set; }
    }
}
