namespace C1DOMAIN.Entities
{
    public class TransacaoDadosEntity : BaseEntity
    {
        public TransacaoDadosEntity(int id, Guid guidId, DateTime transacaoDataCadastro, DateTime transacaoDadosDataAtualizacao, int transacaoId, string cCusto, decimal totalCLiente)//, TransacaoEntity transacao)
            : base(id, guidId) 
        {
            TransacaoDadosDataCadastro = transacaoDataCadastro;
            TransacaoId = transacaoId;
            CCusto = cCusto;
            TotalCliente = totalCLiente;
            TransacaoDadosDataAtualizacao = transacaoDadosDataAtualizacao;
            //Transacao = transacao;
        }

        public DateTime TransacaoDadosDataCadastro { get; private set; }
        public DateTime TransacaoDadosDataAtualizacao { get; private set; }
        public int TransacaoId { get; private set; }
        public string CCusto { get; private set; }
        public decimal TotalCliente { get; private set; }
        //public TransacaoEntity Transacao { get; private set; } // Navigation property
    }
}
