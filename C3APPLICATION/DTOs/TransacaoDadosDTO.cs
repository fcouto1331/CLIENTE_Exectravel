namespace C3APPLICATION.DTOs
{
    public class TransacaoDadosDTO : BaseDTO
    {
        public DateTime TransacaoDadosDataCadastro { get; set; }
        public DateTime TransacaoDadosDataAtualizacao { get; set; }
        public int Transacao_Id { get; set; }
        public string? CCusto { get; set; }
        public decimal TotalCliente { get; set; }
        //public TransacaoDTO? Transacao { get; set; } // Navigation property
    }
}
