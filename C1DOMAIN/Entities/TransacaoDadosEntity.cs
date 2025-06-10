using System;

namespace C1DOMAIN.Entities
{
    public class TransacaoDadosEntity : BaseEntity
    {
        public TransacaoDadosEntity(int id, Guid guidId, DateTime transacaoDadosDataCadastro, DateTime transacaoDadosDataAtualizacao, int transacaoId, string cCusto, decimal totalCliente) //, TransacaoEntity transacao)
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