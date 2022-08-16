namespace CodeFirstileCoreVeriTabanıOlusturma.Model
{
    public class Kitap
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BasımYılı { get; set; }
        public decimal Fiyat { get; set; }
        public Yazar Yazar { get; set; }
        public int YazarID { get; set; }
        public ICollection<Tur> Tur { get; set; }
    }
}
