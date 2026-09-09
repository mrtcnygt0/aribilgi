using System;
using System.Collections.Generic;

namespace EntityDataBaseFirst2.Models;

public partial class Hastalar
{
    public int HastaId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string Sikayetler { get; set; } = null!;

    public DateTime KayitTarihi { get; set; }

    public bool AktifMi { get; set; }

    public double BorcTutari { get; set; }
}
