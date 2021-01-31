﻿using CpmPedidos.Domain;
using CpmPedidos.Repository.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository
{
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        ImagemMap () : base("tb_imagem"){ }

        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(20).IsRequired();
            builder.Property(x => x.NomeArquivo).HasColumnName("nome_arquivo").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Principal).HasColumnName("principal").IsRequired();
        }
    }
}
