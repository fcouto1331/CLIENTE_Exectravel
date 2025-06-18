using System.ComponentModel.DataAnnotations.Schema;

namespace C1DOMAIN.Entities
{
    [Table("TransacaoDados")] // Necessário para mapear a tabela no banco de dados e fazer o bulk insert corretamente
    public class TransacaoDadosLiteEntity : BaseEntity
    {
        public TransacaoDadosLiteEntity(int id, Guid guidId, DateTime transacaoDadosDataCadastro, DateTime transacaoDadosDataAtualizacao, int transacaoId, string cCusto, decimal totalCliente) //, TransacaoEntity transacao)
            : base(id, guidId) 
        {
            TransacaoDadosDataCadastro = transacaoDadosDataCadastro;
            TransacaoDadosDataAtualizacao = transacaoDadosDataAtualizacao;
            TransacaoId = transacaoId;
            CCusto = cCusto;
            TotalCliente = totalCliente;

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