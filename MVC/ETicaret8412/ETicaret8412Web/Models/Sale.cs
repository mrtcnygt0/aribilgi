using System;
using System.Collections.Generic;

namespace ETicaret8412Web.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public DateTime? SaleDate { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
