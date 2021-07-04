using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.InfraStructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");//Se indica manualmente que se dirija a la tabla de ese nombre en la db ya que en el codigo esta en ingles y en sql server esta en español.

            builder.HasKey(e => e.UserId);

            builder.Property(e => e.UserId)
               .HasColumnName("IdUsuario")
               .ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                .HasColumnName("Nombres")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .HasColumnName("Apellidos")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.BirthDate)
                .HasColumnName("FechaNacimiento")
                .HasColumnType("date");

            builder.Property(e => e.Telephone)
                .HasColumnName("Telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.IsActive)
                .HasColumnName("Activo");
        }
    }
}
