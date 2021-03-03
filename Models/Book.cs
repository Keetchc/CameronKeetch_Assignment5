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
        [Required]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        //Regular expression requires it to be in ###-##########
        [RegularExpression(@"^[0-9]\d{3}-\d{10}")]
        public string ISBN { get; set; }

        [Required]
        public string Classification{ get; set; }
        
        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
