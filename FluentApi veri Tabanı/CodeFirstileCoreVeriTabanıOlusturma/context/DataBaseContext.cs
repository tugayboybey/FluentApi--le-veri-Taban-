using CodeFirstileCoreVeriTabanıOlusturma.Mapping;
using CodeFirstileCoreVeriTabanıOlusturma.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstileCoreVeriTabanıOlusturma.context
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CodeFirstCoreVeriTabanıÇalışması;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KitapMapping())
           .ApplyConfiguration(new YazarMapping())
          .ApplyConfiguration(new TurMapping())
          .ApplyConfiguration(new YazarMapping());

        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<YazarDetay> YazarDetays { get; set; }
        public DbSet<Tur> Turler { get; set; }
 



    }
}
