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
                        Author = "Victor Hugo",
                        Pages = 1488,
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassificationCategory = "Fiction, Classic",
                        Price = 9.95,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Pages = 944,
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 14.58,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Pages = 832,
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 21.54,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Pages = 864,
                        Publisher = "Random House",
                        ISBN = " 978-0812981254 ",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 11.61,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Pages = 528,
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        ClassificationCategory = "Non-Fiction, Historical",
                        Price = 13.33,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Pages = 288,
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        ClassificationCategory = "Fiction, Historical Fiction",
                        Price = 15.95,
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Pages = 304,
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 14.99,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Pages = 240,
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 21.66,
                    },
                    
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Pages = 400,
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984 ",
                        ClassificationCategory = "Non-Fiction, Business",
                        Price = 29.16,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Pages = 642,
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        ClassificationCategory = "Fiction, Thrillers",
                        Price = 15.03,
                    },


                    new Book
                    {
                        Title = "Ender's Game",
                        Author = "Orson Scott Card",
                        Pages = 324,
                        Publisher = "Tor Books",
                        ISBN = "978-1250174468",
                        ClassificationCategory = "Fiction, Sci-Fi",
                        Price = 7.99,
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        Author = "J.K. Rowling",
                        Pages = 607,
                        Publisher = "Scholastic",
                        ISBN = "978-0545029377",
                        ClassificationCategory = "Fiction, Fantasy",
                        Price = 13.86,
                    },

                    new Book
                    {
                        Title = "Way of Kings",
                        Author = "Brandon Sanderson",
                        Pages = 1007,
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        ClassificationCategory = "Fiction, Fantasy",
                        Price = 9.59,
                    });
                context.SaveChanges();
            }
        }
    }
}
