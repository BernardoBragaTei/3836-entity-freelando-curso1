using Freelando.Modelo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelando.Dados.Mapeamentos;
internal class ServicoTypeConfiguration : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> entity)
    {
        entity.ToTable("TB_Servicos");

        entity.Property(e => e.Id).HasColumnName("ID_Servico");
        entity.Property(e => e.Descricao).HasColumnName("DS_Projeto");
        entity
            .Property(e => e.Status)
            .HasConversion(
                fromObj => fromObj.ToString(),
                fromDb => (StatusServico)Enum.Parse(typeof(StatusServico), fromDb)
            );
    }
}
