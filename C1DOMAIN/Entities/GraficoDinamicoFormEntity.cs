namespace C1DOMAIN.Entities
{
    public class GraficoDinamicoFormEntity
    {
        public GraficoDinamicoFormEntity(Guid guidId, string? nSolicitante, string? nAutorizacaoCartao, string? nReserva, string? nAprovador, string? nMotivoDaViagem, string? nPassageiro, string? nProduto, string? nDespesa
            , string? nNomeFornecedor, string? nLocalizador, string? nBilhete, string? nRotaCompleta, string? nVeiculo, string? nVoucher, string? nApartamentos, string? nRegime, string? nQtDiarias, string? nFaturaNumero, string? nNumeroCartao) 
        {
            GuidId = guidId;
            NSolicitante = nSolicitante ?? null;
            NAutorizacaoCartao = nAutorizacaoCartao ?? null;
            NReserva = nReserva ?? null;
            NAprovador = nAprovador ?? null;
            NMotivoDaViagem = nMotivoDaViagem ?? null;
            NPassageiro = nPassageiro ?? null;
            NProduto = nProduto ?? null;
            NDespesa = nDespesa ?? null;
            NNomeFornecedor = nNomeFornecedor ?? null;
            NLocalizador = nLocalizador ?? null;
            NBilhete = nBilhete ?? null;
            NRotaCompleta = nRotaCompleta ?? null;
            NVeiculo = nVeiculo ?? null;
            NVoucher = nVoucher ?? null;
            NApartamentos = nApartamentos ?? null;
            NRegime = nRegime ?? null;
            NQtDiarias = nQtDiarias ?? null;
            NFaturaNumero = nFaturaNumero ?? null;
            NNumeroCartao = nNumeroCartao ?? null;
        }

        public Guid GuidId { get; private set; }

        //public DateTime NDataSolicitacao { get; private set; }

        public string? NSolicitante { get; private set; }
        public string? NAutorizacaoCartao { get; private set; }
        public string? NReserva { get; private set; }
        public string? NAprovador { get; private set; }
        public string? NMotivoDaViagem { get; private set; }
        public string? NPassageiro { get; private set; }
        public string? NProduto { get; private set; }
        public string? NDespesa { get; private set; }
        public string? NNomeFornecedor { get; private set; }
        public string? NLocalizador { get; private set; }
        public string? NBilhete { get; private set; }
        public string? NRotaCompleta { get; private set; }
        public string? NVeiculo { get; private set; }
        public string? NVoucher { get; private set; }
        public string? NApartamentos { get; private set; }
        public string? NRegime { get; private set; }

        //public DateTime? NCheckIn { get; private set; }
        //public DateTime? NCheckOut { get; private set; }
        //public DateTime? NEmbarque { get; private set; }

        public string? NQtDiarias { get; private set; }
        public string? NFaturaNumero { get; private set; }
        public string? NNumeroCartao { get; private set; }

        //public decimal? NTarifaCliente { get; private set; }
        //public decimal? NTaxaDU { get; private set; }
        //public decimal? NTaxasTotal { get; private set; }
        //public decimal? NTaxaEmbarque { get; private set; }
        //public string NObservacao { get; private set; }
    }
}
