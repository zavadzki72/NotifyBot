namespace NotifyBot.Domain.Models.Entities
{
    public class User : BaseEntity
    {
        public User(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public virtual List<AlertConfiguration> AlertConfigurations { get; set; }
    }
}
