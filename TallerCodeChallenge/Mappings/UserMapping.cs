using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerCodeChallenge.Models;

namespace TallerCodeChallenge.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserName);

            builder
                .Property(u => u.UserName)
                .HasColumnType("varchar(200)");

            builder.ToTable("Users") ;
        }
    }
}
