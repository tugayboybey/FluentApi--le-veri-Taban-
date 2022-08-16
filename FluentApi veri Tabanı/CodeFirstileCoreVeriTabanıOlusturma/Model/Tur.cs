namespace CodeFirstileCoreVeriTabanıOlusturma.Model
{
    public class Tur
    {
        public int ID { get; set; }
        public string Türü { get; set; }
        public ICollection<Kitap> KitapTurleri { get; set; }
    }
}
