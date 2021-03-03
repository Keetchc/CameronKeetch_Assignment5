using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    //The SeedData class allows us to pass data into the database through the code. it checks to see if there are migrations, and if not saves the data as added below.
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            OnlineBooksDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<OnlineBooksDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Pages = 1488,
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns", 
                        AuthorLast = "Goodwin",
                        Pages = 944,
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Pages = 832,
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Pages = 864,
                        Publisher = "Random House",
                        ISBN = " 978-0812981254 ",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Pages = 528,
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Pages = 288,
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Pages = 304,
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Pages = 240,
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                    },
                    
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Pages = 400,
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984 ",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Pages = 642,
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 15.03,
                    },


                    new Book
                    {
                        Title = "Ender's Game",
                        AuthorFirst = "Orson Scott",
                        AuthorLast = "Card",
                        Pages = 324,
                        Publisher = "Tor Books",
                        ISBN = "978-1250174468",
                        Classification = "Fiction",
                        Category = "Sci-Fi",
                        Price = 7.99,
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        AuthorFirst = "J.K.",
                        AuthorLast = "Rowling",
                        Pages = 607,
                        Publisher = "Scholastic",
                        ISBN = "978-0545029377",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 13.86,
                    },

                    new Book
                    {
                        Title = "Way of Kings",
                        AuthorFirst = "Brandon",
                        AuthorLast = "Sanderson",
                        Pages = 1007,
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 9.59,
                    });
                context.SaveChanges();
            }
        }
    }
}
