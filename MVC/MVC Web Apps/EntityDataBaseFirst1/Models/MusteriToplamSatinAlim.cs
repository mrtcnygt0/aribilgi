using System;
using System.Collections.Generic;

namespace EntityDataBaseFirst1.Models;

public partial class MusteriToplamSatinAlim
{
    public string CompanyName { get; set; } = null!;

    public decimal? ToplamSatınAlımFiyatı { get; set; }

    public string? Country { get; set; }
}
