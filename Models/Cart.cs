using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment5.Models
{
    public class Cart
    {
        //just need the BookId
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //pass in book and quantity
        public virtual void AddItem(Book book, int qty)
        {

            //go into lines object and find where it equals the bookid
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            //if null add the book and qty
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
             }

            //if not null adds to the quantity
            else
            {
                line.Quantity += qty;
            }
        }

        //removes things from cart
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //clears the entire cart
        public virtual void Clear() => Lines.Clear();


        //computes the total of the cart
        public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);
 

        public class CartLine
        {
            public int CartLineID { get; set; }

            public Book Book { get; set; }

            public int Quantity { get; set; }
        }
    }
}
