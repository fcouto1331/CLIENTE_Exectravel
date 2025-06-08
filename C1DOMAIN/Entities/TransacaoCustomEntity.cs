namespace C1DOMAIN.Entities
{
    public class TransacaoCustomEntity : TransacaoEntity
    {
        public TransacaoCustomEntity(int id, Guid guidId, DateTime transacaoDataCadastro, DateTime transacaoDataAtualizacao, int empresa_Id, int mes, int ano, DateTime periodoIni, DateTime periodoFim, string empresaNome)
            : base(id, guidId, transacaoDataCadastro, transacaoDataAtualizacao, empresa_Id, mes, ano, periodoIni, periodoFim)
        {
            EmpresaNome = empresaNome;
        }

        public string EmpresaNome { get; private set; }
    }
}
