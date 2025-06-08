namespace C1DOMAIN.Entities
{
    public class TransacaoEntity : BaseEntity
    {
        public TransacaoEntity(int id, Guid guidId, DateTime transacaoDataCadastro, DateTime transacaoDataAtualizacao, int empresa_Id, int mes, int ano, DateTime periodoIni, DateTime periodoFim)//, TransacaoDadosEntity transacaoDados) 
            : base(id, guidId)
        {
            TransacaoDataCadastro = transacaoDataCadastro;
            TransacaoDataAtualizacao = transacaoDataAtualizacao;
            Empresa_Id = empresa_Id;
            Mes = mes;
            Ano = ano;
            PeriodoIni = periodoIni;
            PeriodoFim = periodoFim;
            //TransacaoDados = transacaoDados;
        }

        public DateTime TransacaoDataCadastro { get; private set; }
        public DateTime TransacaoDataAtualizacao { get; private set; }
        public int Empresa_Id { get; private set; }
        public int Mes { get; private set; } 
        public int Ano { get; private set; }
        public DateTime PeriodoIni { get; private set; }
        public DateTime PeriodoFim { get; private set; }
        //public TransacaoDadosEntity TransacaoDados { get; private set; } // Navigation property
    }
}
