using System;
using System.Collections.Generic;

namespace EntityDataBaseFirst1.Models;

public partial class Satislar
{
    public int SatisId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? MusteriId { get; set; }

    public int? Tutar { get; set; }

    public int? Adet { get; set; }
}
