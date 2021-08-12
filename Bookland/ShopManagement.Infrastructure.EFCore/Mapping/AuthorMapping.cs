using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.AuthorAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName).HasMaxLength(300).IsRequired();

            builder.HasMany(x => x.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x=>x.AuthorId);
        }
    }
}
