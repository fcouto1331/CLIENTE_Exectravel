namespace C1DOMAIN.Entities
{
    public class EmpresaEntity : BaseEntity
	{
		public EmpresaEntity(int id, Guid guidId, bool empresaStatus, DateTime empresaDataCadastro, string nome)
			: base(id, guidId)
		{
			EmpresaStatus = empresaStatus;
			EmpresaDataCadastro = empresaDataCadastro;
			Nome = nome;
		}
		public bool EmpresaStatus { get; private set; }
		public DateTime EmpresaDataCadastro { get; private set; }
		public string Nome { get; private set; }
    }
}
