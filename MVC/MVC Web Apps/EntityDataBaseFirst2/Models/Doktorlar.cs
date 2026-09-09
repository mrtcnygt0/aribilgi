using System;
using System.Collections.Generic;

namespace EntityDataBaseFirst2.Models;

public partial class Doktorlar
{
    public int DoktorId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string UzmanlikAlani { get; set; } = null!;

    public double Maasi { get; set; }
}
