using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    public class OnlineBooksDbContext : DbContext
    {
        //Constructor to build the instance of the object, takes from the base options inherits base options of DbContext
        public OnlineBooksDbContext (DbContextOptions<OnlineBooksDbContext> options) : base (options)
        {
           
        }

        //a property that creates a DbSet of Books
        public DbSet<Book> Books { get; set; }
    }
}
