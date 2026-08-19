using Projekt.Aplication.DTO.Reservation;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface IReservationService
    {
        public Task<Reservation?> GetByIdAsync(int id);
        public Task<IEnumerable<Reservation>> GetAllAsync();
        public Task<bool> DeleteByIdAsync(int id);
        public Task<Reservation> CreateAsync(CreateReservationDto dto);
        
    }
}
