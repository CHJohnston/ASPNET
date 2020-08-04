using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASPNET.Models
{
    public class Review
    {
        public Review()
            {
            }
        public int ReviewID  { get; set; }
        public int ProductID { get; set; }

        [Required(ErrorMessage = "You Must Enter Your Name")] 
        public string Reviewer { get; set; }

        [Required(ErrorMessage = "You Must Enter a Rating of 1 to 5")] 
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}


