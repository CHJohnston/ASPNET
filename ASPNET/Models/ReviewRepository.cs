using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace ASPNET.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly IDbConnection _conn;
        public ReviewRepository(IDbConnection conn)
        {
            _conn = conn;
        }
               
        public IEnumerable<Review> GetAllReviewForASingleProduct(int pid)
        {
            {
                return _conn.Query<Review>("SELECT * FROM REVIEWS WHERE PRODUCTID = @id",
                new { id = pid });
            }
        }

        public void InsertReview(Review reviewToInsert)
        {
            _conn.Execute("INSERT INTO reviews (PRODUCTID, REVIEWER, RATING, COMMENT) VALUES (@productid, @reviewer, @rating, @comment);",
                new { productid = reviewToInsert.ProductID, reviewer = reviewToInsert.Reviewer, rating = reviewToInsert.Rating, comment = reviewToInsert.Comment});
        }
    }
}

