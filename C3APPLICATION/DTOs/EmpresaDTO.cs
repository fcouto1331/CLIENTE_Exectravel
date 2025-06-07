namespace C1DOMAIN.Entities
{
    public class EmpresaDTO : BaseDTO
	{
		public bool EmpresaStatus { get; set; }
		public DateTime EmpresaDataCadastro { get; set; }
		public string? Nome { get; set; }
    }
}
