using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schaffolding.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    [MaxLength(100)]
    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
