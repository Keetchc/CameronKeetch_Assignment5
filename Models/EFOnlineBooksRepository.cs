using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    public class EFOnlineBooksRepository : IOnlineBooksRepository
    {
        private OnlineBooksDbContext _context;
        
        //this is a constructor takes the context and stores it in the private _context property
        public EFOnlineBooksRepository (OnlineBooksDbContext context)
        {
            _context = context;
        }

        //When we call EFOnlineBooks, the Books are set to the _context.Books
        public IQueryable<Book> Books => _context.Books;
    }
}
