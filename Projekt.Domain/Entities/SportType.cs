using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Domain.Entities
{
    public class SportType : BaseEntity
    {
       
        public string Name { get; set; }
        public ICollection<Terrain> Terrains { get; set; } = new List<Terrain>();
    }
}
