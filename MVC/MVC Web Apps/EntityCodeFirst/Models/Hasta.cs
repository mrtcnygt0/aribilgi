namespace EntityCodeFirst.Models
{
    public class Hasta
    {
        public int HastaID { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Sikayetler { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AktifMi { get; set; }
        public double BorcTutari { get; set; }

    }
}
