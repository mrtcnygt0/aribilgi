namespace KendimiDeniyorum.Models
{
    public class Sinav
    {
        public string OgrAd { get; set; }
        public DateTime Tarih { get; set; }
        public string Ders { get; set; }
        public double Puan { get; set; }

        public override string ToString()
        {
            return $"Öğrenci Adı:{OgrAd} \r\nTarih: {Tarih}\r\nDers Adı:{Ders}\r\nPuan: {Puan}";

        }


    }
}
