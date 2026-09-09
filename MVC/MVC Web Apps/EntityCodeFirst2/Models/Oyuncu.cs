namespace EntityCodeFirst2.Models
{
    public class Oyuncu
    {
        public int OyuncuID { get; set; }
        public string OyuncuName { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public double XP { get; set; }

    }
}
