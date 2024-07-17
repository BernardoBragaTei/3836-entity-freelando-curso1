using Freelando.Api.Requests;
using Freelando.Api.Responses;
using Freelando.Modelo;

namespace Freelando.Api.Converters;

public class ContratoConverter
{
    private ServicoConverter? _servicoConverter;
    public ContratoResponse EntityToResponse(Contrato? contrato)
    {
        _servicoConverter = new ServicoConverter();
        if (contrato == null)
        {
            return new ContratoResponse(Guid.Empty, 0.0, null, Guid.Empty);
        }

        return new ContratoResponse(contrato.Id, contrato.Valor, contrato.Vigencia, contrato.ServicoId);
    }

    public Contrato RequestToEntity(ContratoRequest? contratoRequest)
    {
        if (contratoRequest == null)
        {
            return new Contrato(Guid.Empty, 0.0, null, null);
        }

        return new Contrato(contratoRequest.Id, contratoRequest.Valor, contratoRequest.Vigencia, _servicoConverter.RequestToEntity(contratoRequest.Servico));
    }

    public ICollection<ContratoResponse> EntityListToResponseList(IEnumerable<Contrato> contratos)
    {
        return (contratos == null)
            ? new List<ContratoResponse>()
            : contratos.Select(a => EntityToResponse(a)).ToList();
    }

    public ICollection<Contrato> RequestListToEntityList(IEnumerable<ContratoRequest> contratosRequests)
    {
        if (contratosRequests == null)
        {
            return new List<Contrato>();
        }

        return contratosRequests.Select(a => RequestToEntity(a)).ToList();
    }
}
