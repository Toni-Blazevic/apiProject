using Projekt.Aplication.DTO.Review;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface IReviewService
    {
        public Task<Review> CreateAsync(CreateReviewDto dto);
        public Task<bool> DeleteAsync(int id);
        public Task<Review> GetAsync(int id);
    }
}
