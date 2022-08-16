using CodeFirstileCoreVeriTabanıOlusturma.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstileCoreVeriTabanıOlusturma.Mapping
{
    public class YazarMapping : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.ToTable("Yazarlar");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Ad).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Soyad).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.DogumTarihi).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();

            builder.HasOne(yazar => yazar.YazarDetay).WithOne(x => x.Yazar).HasForeignKey<Yazar>(x => x.DetayID);




        }
    }
}
