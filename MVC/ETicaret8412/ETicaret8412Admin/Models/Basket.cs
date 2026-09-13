using System;
using System.Collections.Generic;

namespace ETicaret8412Admin.Models;

public partial class Basket
{
    public int BasketId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ProductId { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
