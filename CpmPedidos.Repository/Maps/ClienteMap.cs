using CpmPedidos.Domain;
using CpmPedidos.Repository.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Repository
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        ClienteMap () : base("tb_cliente"){ }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
        }
    }
}
