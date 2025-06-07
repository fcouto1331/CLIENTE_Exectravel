namespace C1DOMAIN.Entities
{
    public class FilialEntity : BaseEntity
    {
        public FilialEntity(int id, Guid guidId, bool filialStatus, string nome)
            : base(id, guidId)
        {
            FilialStatus = filialStatus;
            Nome = nome;
        }
        public bool FilialStatus { get; private set; }
        public string Nome { get; private set; }
    }    
}
