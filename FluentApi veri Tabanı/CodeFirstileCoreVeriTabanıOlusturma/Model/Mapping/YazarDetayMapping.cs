using CodeFirstileCoreVeriTabanıOlusturma.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstileCoreVeriTabanıOlusturma.Mapping
{
    public class YazarDetayMapping : IEntityTypeConfiguration<YazarDetay>
    {
        public void Configure(EntityTypeBuilder<YazarDetay> builder)
        {
            builder.ToTable("YazarDetaylari");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.Yazarİli).IsRequired();
            builder.Property(x => x.Yazarİli).HasMaxLength(255);
        }
    }
}
