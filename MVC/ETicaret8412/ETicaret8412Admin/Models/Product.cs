using System;
using System.Collections.Generic;

namespace ETicaret8412Admin.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public virtual ICollection<Basket> Baskets { get; set; } = new List<Basket>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
