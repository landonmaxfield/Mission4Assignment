using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission4Assignment.Models
{
    public class Rating 
    {
        [Key]
        [Required]
        
        public int RatingID { get; set; }
        public Rating Ratings;
    }
}
