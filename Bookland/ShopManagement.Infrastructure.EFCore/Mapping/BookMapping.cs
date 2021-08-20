using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.BookAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ShortDescription).IsRequired();
            builder.Property(x => x.Format).HasMaxLength(150);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(255).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(500).IsRequired();

            builder.Property(x => x.Publisher).HasMaxLength(500);
            builder.Property(x => x.Isbn).HasMaxLength(13).IsRequired();
            builder.Property(x => x.Language).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Slug).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();

            builder.Property(x => x.PageCount);
            builder.Property(x => x.PublishDate);

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.AuthorId);

            builder.HasMany(x => x.Banners)
                .WithOne(x => x.Book)
                .HasForeignKey(x => x.BookId);

        }
    }
}
