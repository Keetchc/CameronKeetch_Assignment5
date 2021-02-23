using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models.ViewModels
{
    public class PagingInfo
    {
        //total number of items in database
        public int TotalNumItems { get; set; }

        //total items per page displayed
        public int ItemsPerPage { get; set; }
        
        //current page that is being displayed
        public int CurrentPage { get; set; }

        //calculates the total page needed
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
