using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(P => P.Id);
            builder.Property(P => P.Nombre)
                .IsRequired();
            builder.Property(P => P.Apellido)
                .IsRequired();
            builder.Property(P => P.FechaNacimiento)
                .IsRequired();
            builder.Property(P => P.Telefono)
                .IsRequired();
            builder.Property(P => P.Email)
               .HasMaxLength(100);
            builder.Property(P => P.Direccion)
               .HasMaxLength(120);
            builder.Property(P => P.Edad);
            builder.Property(P => P.CreateBy)
              .HasMaxLength(120);
            builder.Property(P => P.LastModifyBy)
             .HasMaxLength(120);
        }
    }
}
