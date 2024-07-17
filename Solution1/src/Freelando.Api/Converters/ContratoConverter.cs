using Freelando.Api.Requests;
using Freelando.Api.Responses;
using Freelando.Modelo;

namespace Freelando.Api.Converters;

public class ContratoConverter
{
    public ContratoResponse EntityToResponse(Contrato? contrato)
    {
        if (contrato == null)
        {
            return new ContratoResponse(Guid.Empty, 0.0, null);
        }

        return new ContratoResponse(contrato.Id, contrato.Valor, contrato.Vigencia);
    }

    public Contrato RequestToEntity(ContratoRequest? contratoRequest)
    {
        if (contratoRequest == null)
        {
            return new Contrato(Guid.Empty, 0.0, null);
        }

        return new Contrato(contratoRequest.Id, contratoRequest.Valor, contratoRequest.Vigencia);
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
