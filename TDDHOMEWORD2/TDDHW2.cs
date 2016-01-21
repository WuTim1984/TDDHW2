using System.Collections.Generic;
using System.Linq;

namespace TDDHOMEWORD2
{
    public class TDDHW2 
    {
        public double Accounting(List<Book> booklist)
        {  
            double sum = 0;
            sum = booklist.Sum(x => x.Quantity * x.price);
            return sum;
        }
    }

    public class Book
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int price { get; set; }
    }
}