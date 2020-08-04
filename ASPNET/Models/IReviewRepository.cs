using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Models
{
    public interface IReviewRepository
    {
        public IEnumerable<Review> GetAllReviewForASingleProduct(int id);

        public void InsertReview(Review reviewToInsert);       

    }
}
