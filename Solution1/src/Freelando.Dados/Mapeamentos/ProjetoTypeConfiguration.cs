using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelando.Dados.Mapeamentos
{
    internal class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> entity)
        {
            entity.ToTable("TB_Projetos");
            entity.Property(e => e.Id).HasColumnName("Id_Projeto");
            entity.Property(e => e.Titulo).HasColumnName("Titulo");
            entity.Property(e => e.Descricao).HasColumnName("DS_Projeto");
            entity.Property(e => e.Status).HasColumnName("Status");
        }
    }
}
