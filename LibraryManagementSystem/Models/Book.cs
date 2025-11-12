using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book // Id, BookId
    {
        [Key]
        public string ISBN { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Author { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string About { get; set; }
        //[Column(TypeName = "decimal(12)")]
        [Precision(12)] // => decimal(12)
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
    }
}
