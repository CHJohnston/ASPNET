using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository repo;

        public ReviewController(IReviewRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult ViewReview(int id)
        {
            var reviews = repo.GetAllReviewForASingleProduct(id);           
            return View(reviews);           
        }


        public IActionResult InsertReview(int id)
        {
            var review = new Review();
            review.ProductID = id;
            return View(review);
        }
        public IActionResult InsertReviewToDatabase(Review reviewToInsert)        
        {
            repo.InsertReview(reviewToInsert);          
            return RedirectToAction("ViewReview", new { id = reviewToInsert.ProductID });
        }
                
    }
}
