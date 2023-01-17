namespace NotifyBot.Domain.Models.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }
        public BaseEntity(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
