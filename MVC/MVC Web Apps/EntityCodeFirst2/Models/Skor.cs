namespace EntityCodeFirst2.Models
{
    public class Skor
    {
        public int SkorID { get; set; }
        public DateTime Tarih { get; set; }
        public int OyuncuID { get; set; }
        public double Puan { get; set; }
    }
}
