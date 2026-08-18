using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Entities
{
    public class Review : BaseEntity
    {

        public int UserId { get; set; }
        public User User { get; set; }
        public int? TerrainId { get; set; }
        public Terrain? Terrain { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
