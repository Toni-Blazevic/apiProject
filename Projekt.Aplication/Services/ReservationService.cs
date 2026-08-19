using Projekt.Aplication.DTO.Reservation;
using Projekt.Aplication.Interfaces;
using Projekt.Aplication.Mapping;
using Projekt.Domain.Entities;
using Projekt.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<Reservation> CreateAsync(CreateReservationDto dto)
        {
            var reservation = await _reservationRepository.AddAsync(dto.ToEntity());
            await _reservationRepository.SaveChangesAsync();

            return reservation;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            if(!await _reservationRepository.ExistsAsync(id))
            {
                return false;
            }

            await _reservationRepository.DeleteAsync(await _reservationRepository.GetByIdAsync(id));
            await _reservationRepository.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _reservationRepository.GetAllAsync();
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await _reservationRepository.GetByIdAsync(id);
        }
    }
}
