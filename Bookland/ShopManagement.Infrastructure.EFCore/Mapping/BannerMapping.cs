using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.BannerAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class BannerMapping : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Tag).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Book)
                .WithMany(x => x.Banners)
                .HasForeignKey(x => x.BookId);
        }
    }
}
