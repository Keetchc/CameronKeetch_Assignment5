using CameronKeetch_Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CameronKeetch_Assignment5.Models.ViewModels;

namespace CameronKeetch_Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IOnlineBooksRepository _repository;

        //number of Books per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IOnlineBooksRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //pass in the _repository variable and pass the Books created. Also deals with how many pages and items per page
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new BookListViewModel
            {
                //Passing in book information
                Books = _repository.Books
                                         .Where(p => category == null || p.Category == category)
                                         .OrderBy(p => p.BookId)
                                         .Skip((pageNum - 1) * PageSize)
                                         .Take(PageSize)
                ,

                //Passing in page info
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Books.Count() :
                        _repository.Books.Where(x => x.Category == category).Count()
                },

                CurrentCategory = category

            }) ;     
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
