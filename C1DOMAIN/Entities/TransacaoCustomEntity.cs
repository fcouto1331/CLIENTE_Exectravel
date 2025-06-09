namespace C1DOMAIN.Entities
{
    public class TransacaoCustomEntity : TransacaoEntity
    {
        public TransacaoCustomEntity(int id, Guid guidId, DateTime transacaoDataCadastro, DateTime transacaoDataAtualizacao, int empresaId, int mes, int ano, DateTime periodoIni, DateTime periodoFim, string empresaNome)
            : base(id, guidId, transacaoDataCadastro, transacaoDataAtualizacao, empresaId, mes, ano, periodoIni, periodoFim)
        {
            EmpresaNome = empresaNome;
        }

        public string EmpresaNome { get; private set; }
    }
}
