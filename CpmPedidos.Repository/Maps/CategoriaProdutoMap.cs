﻿using CpmPedidos.Domain;
using CpmPedidos.Repository.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository
{
    public class CategoriaProdutoMap : BaseDomainMap<CategoriaProduto>
    {
        CategoriaProdutoMap () : base("tb_CategoriaProduto"){ }

        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();           
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }
    }
}
