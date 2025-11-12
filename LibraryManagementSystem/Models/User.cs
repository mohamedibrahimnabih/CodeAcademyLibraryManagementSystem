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
    internal class User
    {
        public string Id { get; set; }

      //  [MaxLength(256)] // => nvarchar(256)
      //  [Unicode(false)] // => varchar(256)

        [MaxLength(256), Unicode(true)] // => varchar(256)
        public string FirstName { get; set; }
        [MaxLength(256), Unicode(true)] // => varchar(256)
        public string LastName { get; set; }
        [MaxLength(256), Unicode(true)] // => varchar(256)
        public string PhoneNumber { get; set; }
        [MaxLength(256), Unicode(false)] // => varchar(256)
        public string Email { get; set; }
        [MaxLength(256), Unicode(false)] // => varchar(256)
        public string? Address { get; set; }
        [NotMapped]
        public DateOnly DOB { get; set; }
    }
}
