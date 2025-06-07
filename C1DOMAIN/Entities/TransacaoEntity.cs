namespace C1DOMAIN.Entities
{
    public class TransacaoEntity : BaseEntity
    {
        public TransacaoEntity(int id, Guid guidId, bool transacaoStatus, DateTime transacaoDataCadastro, DateTime dataAtualizacao, int empresa_Id, string mes, string ano)//, TransacaoDadosEntity transacaoDados) 
            : base(id, guidId)
        {
            TransacaoStatus = transacaoStatus;
            TransacaoDataCadastro = transacaoDataCadastro;
            DataAtualizacao = dataAtualizacao;
            Empresa_Id = empresa_Id;
            Mes = mes;
            Ano = ano;
            //TransacaoDados = transacaoDados;
        }

        public bool TransacaoStatus { get; private set; }
        public DateTime TransacaoDataCadastro { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public int Empresa_Id { get; private set; }
        public string Mes { get; private set; } // Resolve Dapper char()
        public string Ano { get; private set; } // Resolve Dapper char()
        //public TransacaoDadosEntity TransacaoDados { get; private set; } // Navigation property
    }
}
