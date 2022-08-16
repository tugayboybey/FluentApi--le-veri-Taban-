using CodeFirstileCoreVeriTabanıOlusturma.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstileCoreVeriTabanıOlusturma.Mapping
{
    public class KitapMapping : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.ToTable("Kitaplar");
            builder.HasKey(x => x.ID);
                builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Fiyat).HasColumnType("decimal(10,2)").HasPrecision(10,2);
            builder.Property(x => x.BasımYılı).HasColumnType("int").IsRequired();

            builder.HasOne(kitap => kitap.Yazar)//hasmany kullanılması lazım değilmi?
                .WithMany(yazar => yazar.Kitaplar)
                .HasForeignKey(x => x.YazarID);

          //  builder.HasMany(x => x.Tur).WithMany(x => x.KitapTurleri);


        }
    }
}
