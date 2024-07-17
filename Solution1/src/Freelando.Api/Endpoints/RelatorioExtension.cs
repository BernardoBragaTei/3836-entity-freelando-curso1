using Freelando.Dados;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Freelando.Api.Endpoints;

public static class RelatorioExtension
{
    public static void AddEndPointRelatorios(this WebApplication app)
    {
        app.MapGet("/relatorios/precoContrato", ([FromServices] FreelandoContext contexto) =>
        {
            var consulta = contexto.Contratos.FromSql($"SELECT * FROM dbo.TB_Contratos WHERE TB_Contratos.Valor > 1000").ToList();
            return consulta;
        }).WithTags("Relatórios").WithOpenApi();

    }
}
