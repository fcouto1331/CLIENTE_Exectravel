namespace C1DOMAIN.Entities
{
    public class BaseEntity
    {
        public BaseEntity(int id, Guid guidId)
        {
            Id = id;
            GuidId = guidId;
        }

        public int Id { get; private set; }
        public Guid GuidId { get; private set; }
    }
}
