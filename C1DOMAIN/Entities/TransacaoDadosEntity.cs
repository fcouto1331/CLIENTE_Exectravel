namespace C1DOMAIN.Entities
{
    public class TransacaoDadosEntity : BaseEntity
    {
        public TransacaoDadosEntity(int id, Guid guidId, DateTime transacaoDataCadastro, int transacao_Id, string cCusto, decimal totalCLiente)//, TransacaoEntity transacao)
            : base(id, guidId) 
        {
            TransacaoDadosDataCadastro = transacaoDataCadastro;
            Transacao_Id = transacao_Id;
            CCusto = cCusto;
            TotalCliente = totalCLiente;
            //Transacao = transacao;
        }

        public DateTime TransacaoDadosDataCadastro { get; private set; }
        public int Transacao_Id { get; private set; }
        public string CCusto { get; private set; }
        public decimal TotalCliente { get; private set; }
        //public TransacaoEntity Transacao { get; private set; } // Navigation property
    }
}
