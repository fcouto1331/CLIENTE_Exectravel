using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;
using C1DOMAIN.Services;
using C2INFRA_SQL.Dapper;
using C2INFRA_SQL.Repositories;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Services;

namespace C4PRESENTATION_WEB.Extensions
{
    public static class InterfacesExtension
    {
        public static void AddInterfaces(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IEmpresaApp, EmpresaApp>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
            services.AddScoped<ITransacaoService, TransacaoService>();
            services.AddScoped<ITransacaoApp, TransacaoApp>();
        }
    }
}
