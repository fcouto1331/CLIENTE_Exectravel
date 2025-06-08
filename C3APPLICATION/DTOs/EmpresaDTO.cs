namespace C3APPLICATION.DTOs
{
    public class EmpresaDTO : BaseDTO
	{
		public bool EmpresaStatus { get; set; }
		public DateTime EmpresaDataCadastro { get; set; }
		public string? Nome { get; set; }
    }
}
