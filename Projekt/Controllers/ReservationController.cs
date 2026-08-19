using Microsoft.AspNetCore.Mvc;
using Projekt.Aplication.DTO.Reservation;
using Projekt.Aplication.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Projekt.API.Controllers
{
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {

        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetReservationById(int id)
        {
            var reservation = await _reservationService.GetByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return Ok(reservation);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllReservation()
        {
            return Ok(await _reservationService.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult> CreateReservation(CreateReservationDto dto)
        {
            var reservation = await _reservationService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAllReservation), new { id = reservation.Id }, reservation);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteReservationById(int id)
        {
            if(!await _reservationService.DeleteByIdAsync(id))
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
