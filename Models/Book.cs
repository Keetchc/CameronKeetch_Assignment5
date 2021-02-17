using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }
        
        public string Author { get; set; }

        public string Publisher { get; set; }

        //Regular expression requires it to be in ###-##########
        [RegularExpression(@"^[0-9]\d{3}-\d{10}")]
        public string ISBN { get; set; }

        public string ClassificationCategory { get; set; }

        public double Price { get; set; }
    }
}
