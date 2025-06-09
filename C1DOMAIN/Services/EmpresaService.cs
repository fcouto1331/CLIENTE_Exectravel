using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;

namespace C1DOMAIN.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _repository;
        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public List<EmpresaCustomEntity> ListarParaSelect() => _repository.ListarParaSelect();
    }
}
