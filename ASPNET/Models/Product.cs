using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Models
{
    public class Product
    {
        public Product()
        { }
        [Dapper.Contrib.Extensions.Key]
        [Display(Name = "Product Id")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "You Must have a Product Name")] public string Name { get; set; }                
        [Required(ErrorMessage = "You Must Enter a Price")] public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

