using Projekt.Aplication.Interfaces;
using Projekt.Domain.Entities;
using Projekt.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Services
{
    public class SportTypeService : ISportTypeService
    {
        private readonly ISportTypeRepository _sportTypeRepository;

        public SportTypeService(ISportTypeRepository sportTypeRepository)
        {
            _sportTypeRepository = sportTypeRepository;
        }
        public async Task<SportType?> GetByIDAsync(int id)
        {
            return await _sportTypeRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<SportType>> GetAllAsync()
        {
            return await _sportTypeRepository.GetAllAsync();
        }

    }
}
