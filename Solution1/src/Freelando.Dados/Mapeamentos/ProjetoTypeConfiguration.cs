using Freelando.Modelo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelando.Dados.Mapeamentos;
internal class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> entity)
    {
        entity.ToTable("TB_Projetos");

        entity.HasKey(e => e.Id).HasName("PK_Projeto");

        entity.Property(e => e.Id).HasColumnName("Id_Projeto");

        entity.Property(e => e.Descricao)
            .HasColumnType("nvarchar(200)")
            .HasColumnName("DS_Projeto");

    }
}
