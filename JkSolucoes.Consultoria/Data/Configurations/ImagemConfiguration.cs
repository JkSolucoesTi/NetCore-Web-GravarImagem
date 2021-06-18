using JkSolucoes.Consultoria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JkSolucoes.Consultoria.Data.Configurations
{
    public class ImagemConfiguration : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.ToTable("Imagem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Extension)             
                .IsRequired();
            builder.Property(x => x.Length)
                .IsRequired();
            builder.Property(x => x.Picture);
            builder.Property(x => x.ContentType)
                .IsRequired();

        }
    }
}
