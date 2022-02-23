using System;
using Microsoft.EntityFrameworkCore;
namespace Mission4Assignment.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        { }

        public DbSet<Applicationresponse> Responses { get; set; }

        public DbSet<Rating> Ratings {get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Applicationresponse>().HasData(

                new Applicationresponse
                {
                    MovieTitle = "cars",
                    Category = "Animation",
                    Year = 2007,
                    Director = "Disney",
                    RatingID = "G",
                    Edited = "No",
                    LentTo = "no one",
                    Notes = "cinematic masterpiece"
                },
                new Applicationresponse
                {
                    MovieTitle = "Up",
                    Category = "Animation",
                    Year = 2009,
                    Director = "Disney",
                    RatingID = "G",
                    Edited = "No",
                    LentTo = "no one",
                    Notes = "amazing cinematic masterpiece"
                }
             );
        }
    }
}
