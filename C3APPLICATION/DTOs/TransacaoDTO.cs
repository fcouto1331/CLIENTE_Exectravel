namespace C3APPLICATION.DTOs
{
    public class TransacaoDTO : BaseDTO
    {
        public DateTime TransacaoDataCadastro { get; set; }
        public DateTime TransacaoDataAtualizacao { get; set; }
        public int EmpresaId { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime PeriodoIni { get; set; }
        public DateTime PeriodoFim { get; set; }
        //public TransacaoDadosDTO? TransacaoDados { get; set; } // Navigation property
    }
}
