using Microsoft.AspNetCore.Mvc;
using Projekt.Aplication.Interfaces;

namespace Projekt.API.Controllers
{
    [Route("api/[controller]")]
    public class SportTypeController : Controller
    {
        private readonly ISportTypeService _sportTypeService;

        public SportTypeController(ISportTypeService sportTypeService)
        {
            _sportTypeService = sportTypeService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSportTypeById(int id)
        {
            var sportType = await _sportTypeService.GetByIDAsync(id);

            if (sportType == null)
            {
                return NotFound();
            }
            return Ok(sportType);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllSportType()
        {
            return Ok(await _sportTypeService.GetAllAsync());
        }
    }
}
