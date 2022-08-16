namespace CodeFirstileCoreVeriTabanıOlusturma.Model
{
    public class Yazar
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime  DogumTarihi { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
        public YazarDetay YazarDetay { get; set; }
        public int DetayID { get; set; }
    }
}
