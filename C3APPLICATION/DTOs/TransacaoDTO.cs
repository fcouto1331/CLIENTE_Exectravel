namespace C1DOMAIN.Entities
{
    public class TransacaoDTO : BaseDTO
    {
        public bool TransacaoStatus { get; set; }
        public DateTime TransacaoDataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int Empresa_Id { get; set; }
        public char Mes { get; set; }
        public char Ano { get; set; }
        public TransacaoDadosDTO? TransacaoDados { get; set; } // Navigation property
    }
}
