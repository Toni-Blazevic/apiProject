using Microsoft.AspNetCore.Mvc;
using Projekt.Aplication.DTO.Terrain;
using Projekt.Aplication.Interfaces;
using Projekt.Domain.Entities;

namespace Projekt.API.Controllers
{
    [Route("api/[controller]")]
    public class TerrainController : Controller
    {
        private readonly ITerrainService _terrainService;

        public TerrainController(ITerrainService terrainService)
        {
            _terrainService = terrainService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTerrainById(int id)
        {
            Terrain? terrain = await _terrainService.GetByIdAsync(id);

            if(terrain == null)
            {
                return NotFound();
            }
            return Ok(terrain);
        }
        [HttpGet]
        public async Task<ActionResult> GetAllTerrain()
        {
            return Ok(await _terrainService.GetAllAsync());
        }

        [HttpGet("{terrainId}/reviews")]
        public async Task<ActionResult> GetTerrainWithReviewsAsync(int terrainId)
        {
            var terrain = await _terrainService.GetTerrainWithReviewsAsync(terrainId);
            if(terrain == null)
            {
                return NotFound();
            }
            return Ok(terrain);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTerain([FromBody] CreateTerrainDto dto)
        {
            var terrain = await _terrainService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetTerrainById), new { id = terrain.Id }, terrain);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTerrainById(int id)
        {
            if(!await _terrainService.DeleteByIdAsync(id))
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTerrain(int id, [FromBody] CreateTerrainDto newTerrain)
        {
            if(!await _terrainService.UpdateByIdAsync(id, newTerrain))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
