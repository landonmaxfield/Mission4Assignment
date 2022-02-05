using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4Assignment.Models
{
    public class Applicationresponse
    {
        [Key]
        [Required]
            public string MovieTitle { get; set; }
            public string Category { get; set; }
            public ushort Year { get; set; }
            public string Director { get; set; }
            public string Rating { get; set; }
            public string Edited { get; set; }
            public string LentTo { get; set; }
            public string Notes { get; set; }
     
    }
}
