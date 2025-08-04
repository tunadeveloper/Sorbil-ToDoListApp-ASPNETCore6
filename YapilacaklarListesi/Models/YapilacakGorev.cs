namespace YapilacaklarListesi.Models
{
    public class YapilacakGorev
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string? Aciklama { get; set; }
        public bool Tamamlandi { get; set; }
        public bool Onemli { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
    }
}
