namespace C3APPLICATION.DTOs
{
    public class GraficoDinamicoFormDTO
    {
        public Guid GuidId { get; set; }

        //public DateTime NDataSolicitacao { get; set; }

        public List<string>? NSolicitante { get; set; }
        public List<string>? NAutorizacaoCartao { get; set; }
        public List<string>? NReserva { get; set; }
        public List<string>? NAprovador { get; set; }
        public List<string>? NMotivoDaViagem { get; set; }
        public List<string>? NPassageiro { get; set; }
        public List<string>? NProduto { get; set; }
        public List<string>? NDespesa { get; set; }
        public List<string>? NNomeFornecedor { get; set; }
        public List<string>? NLocalizador { get; set; }
        public List<string>? NBilhete { get; set; }
        public List<string>? NRotaCompleta { get; set; }
        public List<string>? NVeiculo { get; set; }
        public List<string>? NVoucher { get; set; }
        public List<string>? NApartamentos { get; set; }
        public List<string>? NRegime { get; set; }

        //public DateTime? NCheckIn { get; set; }
        //public DateTime? NCheckOut { get; set; }
        //public DateTime? NEmbarque { get; set; }

        public List<string>? NQtDiarias { get; set; }
        public List<string>? NFaturaNumero { get; set; }
        public List<string>? NNumeroCartao { get; set; }

        //public decimal? NTarifaCliente { get; set; }
        //public decimal? NTaxaDU { get; set; }
        //public decimal? NTaxasTotal { get; set; }
        //public decimal? NTaxaEmbarque { get; set; }
        //public string NObservacao { get; set; }
    }
}
