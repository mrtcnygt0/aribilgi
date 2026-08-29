namespace ModelVerisi.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public string Model {  get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return $"Ürün:{UrunAd} \r\nMarka: {Marka}\r\nModel:{Model}\r\nFiyat: {Fiyat}";

        }


    }
}
