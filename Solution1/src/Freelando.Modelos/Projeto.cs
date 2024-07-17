using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelando.Modelo;
public class Projeto
{
    public Projeto()
    {

    }

    public Projeto(Guid id, string? titulo, string descricao, StatusProjeto status)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Status = status;
    }
    public Guid Id { get; set; }
    public string? Titulo { get; set; }
    public  string? Descricao { get; set; }
    public StatusProjeto Status { get; set; }
}
