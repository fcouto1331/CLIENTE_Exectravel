using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IRepositories
{
    public interface IExcelRepository
    {
        void LerExcelPorStream(MemoryStream stream, ref List<TransacaoDadosExcelEntity> transacaoDadosExcel);

        void LerExcelPorStream(MemoryStream stream, ref List<TransacaoDadosExcelEntity> transacaoDadosExcel, string nomeSheet);
    }
}
