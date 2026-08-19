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
        public async Task<ActionResult> CreateSportCenter([FromBody] CreateSportCentarDto dto)
        {
            var sportCentar = await _sportCenterService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetSportCenterById), new { id = sportCentar.Id }, sportCentar);
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

        [HttpGet("{id}/terrains")]
        public async Task<ActionResult> GetSportCentarWithTerrains(int id)
        {
            var sportCentar = await _sportCenterService.GetSportCentarWithTerrains(id);
            if(sportCentar == null)
            {
                return NotFound();
            }
            return Ok(sportCentar);
        }
    }
}
