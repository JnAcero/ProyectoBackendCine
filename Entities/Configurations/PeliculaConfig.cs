using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace IntroAEFCore.Entities.Configurations
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder){
            builder.Property(p => p.FechaEstreno).HasColumnType("date");
        }
        
    }
}