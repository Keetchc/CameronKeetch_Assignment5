using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    //sets up a template that allows us to implement this in a class
   public interface IOnlineBooksRepository
    {
        IQueryable<Book> Books { get; }
    }
}
