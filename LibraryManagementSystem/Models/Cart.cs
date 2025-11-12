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
    [PrimaryKey(nameof(BookId), nameof(UserId))]
    internal class Cart
    {
        public string BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
