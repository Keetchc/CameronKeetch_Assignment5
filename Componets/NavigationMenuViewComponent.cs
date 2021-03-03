using CameronKeetch_Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CameronKeetch_Assignment5.Componets
{   
    //allows us to drop a componet view in our shared layout, really cool
    public class NavigationMenuViewComponent : ViewComponent 
    {
        //bringing in repository
        private IOnlineBooksRepository _repository;
        
        //set the constructor
        public NavigationMenuViewComponent(IOnlineBooksRepository repository)
        {
            _repository = repository;
        }

        //returns a view of the selected repository
        public IViewComponentResult Invoke()
        {
            //creating ViewBag to use for highlighting purposes
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            //querys to show correct data
            return View(_repository.Books
                        .Select(x => x.Category)
                        .Distinct()
                        .OrderBy(x => x));
        }
    }

    
}
