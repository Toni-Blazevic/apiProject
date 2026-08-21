using Projekt.Aplication.DTO.Review;
using Projekt.Aplication.Interfaces;
using Projekt.Aplication.Mapping;
using Projekt.DAL.Repositories;
using Projekt.Domain.Entities;
using Projekt.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Review> CreateAsync(CreateReviewDto dto)
        {
            var review = await _reviewRepository.AddAsync(dto.ToEntity());
            _reviewRepository.SaveChangesAsync();

            return review;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            if(!await _reviewRepository.ExistsAsync(id))
            {
                return false;
            }

            await _reviewRepository.DeleteAsync(await _reviewRepository.GetByIdAsync(id));
            await _reviewRepository.SaveChangesAsync();

            return true;
        }

        public async Task<Review> GetAsync(int id)
        {
            return await _reviewRepository.GetByIdAsync(id);
        }
    }
}
