using System;
using System.Collections.Generic;

namespace EntityDataBaseFirst1.Models;

public partial class UruneGoreSatisRaporu
{
    public string ProductName { get; set; } = null!;

    public int? ToplamÜrünAdedi { get; set; }

    public decimal? ToplamMaliyet { get; set; }

    public decimal? ToplamSatışTutarı { get; set; }

    public decimal? BrütKar { get; set; }
}
