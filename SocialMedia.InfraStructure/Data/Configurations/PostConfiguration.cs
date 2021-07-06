using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;

namespace SocialMedia.InfraStructure.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {
            
                builder.ToTable("Publicacion");//Se indica manualmente que se dirija a la tabla de ese nombre en la db ya que en el codigo esta en ingles y en sql server esta en español.

                builder.HasKey(e => e.PostId);

                builder.Property(e => e.PostId)
                    .HasColumnName("IdPublicacion");

                builder.Property(e => e.UserId)
                    .HasColumnName("IdUsuario");

                builder.Property(e => e.Description)
                    .HasColumnName("Descripcion")
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                builder.Property(e => e.Date)
                    .HasColumnName("Fecha")
                    .HasColumnType("datetime");

                builder.Property(e => e.Image)
                    .HasColumnName("Imagen")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                builder.HasOne(d => d.User)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicacion_Usuario");
           
        }
    }
}
