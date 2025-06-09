using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IRepositories
{
    public interface IEmpresaRepository
    {
        List<EmpresaCustomEntity> ListarParaSelect();
    }
}
