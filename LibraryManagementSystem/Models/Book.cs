using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book // Id, BookId
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
    }
}
