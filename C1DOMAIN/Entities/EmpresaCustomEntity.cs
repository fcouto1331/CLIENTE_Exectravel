namespace C1DOMAIN.Entities
{
    public class EmpresaCustomEntity : BaseEntity
	{
		public EmpresaCustomEntity(int id, Guid guidId, string nome)
			: base(id, guidId)
		{
			Nome = nome;
		}
		public string Nome { get; private set; }
    }
}
