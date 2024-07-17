using Freelando.Api.Requests;
using Freelando.Api.Responses;
using Freelando.Modelo;

namespace Freelando.Api.Converters;

public class ProjetoConverter
{
    private ClienteConverter? _clienteConverter;
    public ProjetoResponse EntityToResponse(Projeto projeto)
    {
        _clienteConverter = new ClienteConverter();

        return (projeto is null)
            ? new ProjetoResponse(Guid.Empty, "", "", StatusProjeto.Disponivel.ToString(), null)
            : new ProjetoResponse(projeto.Id, projeto.Titulo, projeto.Descricao, projeto.Status.ToString(), _clienteConverter.EntityToResponse(projeto.Cliente));
    }

    public Projeto RequestToEntity(ProjetoRequest projetoRequest)
    {

        return (projetoRequest is null)
            ? new Projeto(Guid.Empty, "", "", StatusProjeto.Disponivel, new Cliente(Guid.Empty, "", "", "", "", new List<Projeto>()))
            : new Projeto(projetoRequest.Id, projetoRequest.Titulo!, projetoRequest.Descricao!, projetoRequest.Status, new Cliente());
    }

    public ICollection<ProjetoResponse> EntityListToResponseList(IEnumerable<Projeto>? projetos)
    {
        return (projetos is null)
            ? new List<ProjetoResponse>()
            : projetos.Select(p => EntityToResponse(p)).ToList();
    }

    public ICollection<Projeto> RequestListToEntityList(IEnumerable<ProjetoRequest>? projetos)
    {
        return (projetos is null)
            ? new List<Projeto>()
            : projetos.Select(a => RequestToEntity(a)).ToList();
    }
}
