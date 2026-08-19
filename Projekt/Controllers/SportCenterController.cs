using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Projekt.Aplication.DTO.SportCentar;
using Projekt.Aplication.Interfaces;
using Projekt.Domain.Entities;

namespace Projekt.API.Controllers
{
    [Route("api/[controller]")]
    public class SportCenterController : Controller
    {
        private readonly ISportCentarService _sportCenterService;

        public SportCenterController(ISportCentarService sportCentarService)
        {
            _sportCenterService = sportCentarService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSportCenterById(int id)
        {
            SportCentar? sportCenter = await _sportCenterService.GetByIdAsync(id);

            if (sportCenter == null)
            {
                return NotFound();
            }
            return Ok(sportCenter);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllSportCenter()
        {
            return Ok(await _sportCenterService.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult> CreateSportCenter([FromBody] CreateSportCentarDto sportCenter)
        {
            await _sportCenterService.CreateAsync(sportCenter);
            return Ok(sportCenter);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSportCentar(int id)
        {

            if(!await _sportCenterService.DeleteByIdAsync(id))
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSportCenter(int id, [FromBody] CreateSportCentarDto newSportCentar)
        {
            if(!await _sportCenterService.UpdateAsync(id, newSportCentar))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
