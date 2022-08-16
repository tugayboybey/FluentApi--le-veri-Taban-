using CodeFirstileCoreVeriTabanıOlusturma.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstileCoreVeriTabanıOlusturma.Mapping
{
    public class TurMapping : IEntityTypeConfiguration<Tur>
    {
        public void Configure(EntityTypeBuilder<Tur> builder)
        {
            builder.ToTable("Tür");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Türü).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            builder.HasMany(tur => tur.KitapTurleri).WithMany(kitap => kitap.Tur);
        }
    }
}
