using C1DOMAIN.Interfaces.IServices;
using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Mapster;


namespace C3APPLICATION.Services
{
    public class EmpresaApp : IEmpresaApp
    {
        private readonly IEmpresaService _service;
        public EmpresaApp(IEmpresaService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public List<EmpresaCustomDTO> ListarParaSelect() => Mapper.ToListEmpresaCustomDTO(_service.ListarParaSelect());

    }
}
