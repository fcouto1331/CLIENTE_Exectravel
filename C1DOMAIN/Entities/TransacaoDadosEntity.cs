using System.ComponentModel.DataAnnotations.Schema;

namespace C1DOMAIN.Entities
{
    [Table("TransacaoDados")] // Necessário para mapear a tabela no banco de dados e fazer o bulk insert corretamente
    public class TransacaoDadosEntity : BaseEntity
    {
        public TransacaoDadosEntity(int id, Guid guidId
            , DateTime transacaoDadosDataCadastro, DateTime transacaoDadosDataAtualizacao, int transacaoId, string cCusto, decimal totalCliente
            , DateTime nDataSolicitacao, string nSolicitante, string nAutorizacaoCartao, string nReserva, string nAprovador, string nMotivoDaViagem
            , string nPassageiro, string nProduto, string nDespesa, string nNomeFornecedor, string nLocalizador, string nBilhete, string nRotaCompleta
            , string nVeiculo, string nVoucher, string nApartamentos, string nRegime, DateTime? nCheckIn, DateTime? nCheckOut, DateTime? nEmbarque
            , int? nQtDiarias, string nFaturaNumero, string nNumeroCartao, decimal? nTarifaCliente, decimal? nTaxaDU, decimal? nTaxasTotal, decimal? nTaxaEmbarque, string nObservacao) //, TransacaoEntity transacao)
            : base(id, guidId) 
        {
            TransacaoDadosDataCadastro = transacaoDadosDataCadastro;
            TransacaoDadosDataAtualizacao = transacaoDadosDataAtualizacao;
            TransacaoId = transacaoId;
            CCusto = cCusto;
            TotalCliente = totalCliente;

            NDataSolicitacao = nDataSolicitacao;
            NSolicitante = String.IsNullOrEmpty(nSolicitante) ? "N/C" : nSolicitante.ToUpper();
            NAutorizacaoCartao = String.IsNullOrEmpty(nAutorizacaoCartao) ? "N/C" : nAutorizacaoCartao; 
            NReserva = String.IsNullOrEmpty(nReserva) ? "N/C" : nReserva;
            NAprovador = String.IsNullOrEmpty(nAprovador) ? "N/C" : nAprovador.ToUpper();
            NMotivoDaViagem = String.IsNullOrEmpty(nMotivoDaViagem) ? "N/C" : nMotivoDaViagem.Replace(";", " ");
            NPassageiro = String.IsNullOrEmpty(nPassageiro) ? "N/C" : nPassageiro.ToUpper();
            NProduto = String.IsNullOrEmpty(nProduto) ? "N/C" : nProduto;
            NDespesa = String.IsNullOrEmpty(nDespesa) ? "N/C" : nDespesa;
            NNomeFornecedor = String.IsNullOrEmpty(nNomeFornecedor) ? "N/C" : nNomeFornecedor.ToUpper();
            NLocalizador = String.IsNullOrEmpty(nLocalizador) ? "N/C" : nLocalizador;
            NBilhete = String.IsNullOrEmpty(nBilhete) ? "N/C" : nBilhete;
            NRotaCompleta = String.IsNullOrEmpty(nRotaCompleta) ? "N/C" : nRotaCompleta;
            NVeiculo = String.IsNullOrEmpty(nVeiculo) ? "N/C" : nVeiculo;
            NVoucher = String.IsNullOrEmpty(nVoucher) ? "N/C" : nVoucher;
            NApartamentos = String.IsNullOrEmpty(nApartamentos) ? "N/C" : nApartamentos;
            NRegime = String.IsNullOrEmpty(nRegime) ? "N/C" : nRegime;
            NCheckIn = nCheckIn ?? null;
            NCheckOut = nCheckOut ?? null;
            NEmbarque = nEmbarque ?? null;
            NQtDiarias = nQtDiarias ?? 0;
            NFaturaNumero = String.IsNullOrEmpty(nFaturaNumero) ? "N/C" : nFaturaNumero;
            NNumeroCartao = String.IsNullOrEmpty(nNumeroCartao) ? "N/C" : nNumeroCartao;
            NTarifaCliente = nTarifaCliente ?? 0;
            NTaxaDU = nTaxaDU ?? 0;
            NTaxasTotal = nTaxasTotal ?? 0;
            NTaxaEmbarque = nTaxaEmbarque ?? 0;
            NObservacao = String.IsNullOrEmpty(nObservacao) ? "N/C" : nObservacao.Replace(";", " ");

            //Transacao = transacao;
        }

        public DateTime TransacaoDadosDataCadastro { get; private set; }
        public DateTime TransacaoDadosDataAtualizacao { get; private set; }
        public int TransacaoId { get; private set; }
        public string CCusto { get; private set; }
        public decimal TotalCliente { get; private set; }

        public DateTime NDataSolicitacao { get; set; }
        public string NSolicitante { get; set; }
        public string NAutorizacaoCartao { get; set; }
        public string NReserva { get; set; }
        public string NAprovador { get; set; }
        public string NMotivoDaViagem { get; set; }
        public string NPassageiro { get; set; }
        public string NProduto { get; set; }
        public string NDespesa { get; set; }
        public string NNomeFornecedor { get; set; }
        public string NLocalizador { get; set; }
        public string NBilhete { get; set; }
        public string NRotaCompleta { get; set; }
        public string NVeiculo { get; set; }
        public string NVoucher { get; set; }
        public string NApartamentos { get; set; }
        public string NRegime { get; set; }
        public DateTime? NCheckIn { get; set; }
        public DateTime? NCheckOut { get; set; }
        public DateTime? NEmbarque { get; set; }
        public int? NQtDiarias { get; set; }
        public string NFaturaNumero { get; set; }
        public string NNumeroCartao { get; set; }
        public decimal? NTarifaCliente { get; set; }
        public decimal? NTaxaDU { get; set; }
        public decimal? NTaxasTotal { get; set; }
        public decimal? NTaxaEmbarque { get; set; }
        public string NObservacao { get; set; }

        //public TransacaoEntity Transacao { get; private set; } // Navigation property
    }
}