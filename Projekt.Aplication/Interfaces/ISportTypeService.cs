using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface ISportTypeService
    {
        public Task<SportType?> GetByIDAsync(int  id);
        public Task<IEnumerable<SportType>> GetAllAsync();
    }
}
