using Freelando.Modelos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freelando.Modelo;

public class Especialidade
{
    public Especialidade()
    {
    }
    public Especialidade(Guid id, string? descricao, ICollection<Projeto> projetos)
    {
        Id = id;
        Descricao = descricao;
        Projetos = projetos;
    }
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public ICollection<Projeto> Projetos { get; set; }
    public List<ProjetoEspecialidade> ProjetosEspecialidades { get; } = [];
}
