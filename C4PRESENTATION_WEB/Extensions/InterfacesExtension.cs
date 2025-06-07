using C1DOMAIN.Interfaces.IRepositories;
using C2INFRA_SQL.Dapper;
using C2INFRA_SQL.Repositories;

namespace C4PRESENTATION_WEB.Extensions
{
    public static class InterfacesExtension
    {
        public static void AddInterfaces(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
        }
    }
}
