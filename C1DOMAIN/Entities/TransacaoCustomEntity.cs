namespace C1DOMAIN.Entities
{
    public class TransacaoCustomEntity : TransacaoEntity
    {
        public TransacaoCustomEntity(int id, Guid guidId, bool transacaoStatus, DateTime transacaoDataCadastro, DateTime dataAtualizacao, int empresa_Id, string mes, string ano, string empresaNome)
            : base(id, guidId, transacaoStatus, transacaoDataCadastro, dataAtualizacao, empresa_Id, mes, ano)
        {
            EmpresaNome = empresaNome;
        }

        public string EmpresaNome { get; private set; }
    }
}
