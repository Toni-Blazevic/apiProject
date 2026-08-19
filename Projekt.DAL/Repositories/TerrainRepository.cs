using Projekt.DAL.Data;
using Projekt.Domain.Entities;
using Projekt.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DAL.Repositories
{
    public class TerrainRepository : Repository<Terrain>, ITerrainRepository
    {
        public TerrainRepository(ProjektContext context) : base(context)
        {
        }
    }
}
