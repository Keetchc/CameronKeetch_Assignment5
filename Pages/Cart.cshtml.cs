using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CameronKeetch_Assignment5.Infrastructure;
using CameronKeetch_Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CameronKeetch_Assignment5.Pages
{
    public class CartModel : PageModel
    {
        private IOnlineBooksRepository repository;


        //Constructor
        public CartModel (IOnlineBooksRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //Properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }
       
        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(lines =>
            lines.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
