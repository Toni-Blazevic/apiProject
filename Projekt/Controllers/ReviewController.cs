using Microsoft.AspNetCore.Mvc;
using Projekt.Aplication.DTO.Review;
using Projekt.Aplication.Interfaces;
using Projekt.Aplication.Services;

namespace Projekt.API.Controllers
{
    [Route("[controller]")]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetReviewAsync(int id)
        {
            var review = await _reviewService.GetAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        [HttpPost]
        public async Task<ActionResult> CreateReview(CreateReviewDto dto)
        {
            var review = await _reviewService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetReviewAsync), new { id = review.Id }, review);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteReview(int id)
        {
            if (!await _reviewService.DeleteAsync(id))
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
