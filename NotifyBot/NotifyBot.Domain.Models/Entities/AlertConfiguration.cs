using NotifyBot.Domain.Models.Enumerators;

namespace NotifyBot.Domain.Models.Entities
{
    public class AlertConfiguration : BaseEntity
    {
        public AlertConfiguration(int userId, AlertType alertType)
        {
            UserId = userId;
            AlertType = alertType;

            IsActive = true;
        }

        public int UserId { get; private set; }
        public AlertType AlertType { get; private set; }
        public bool IsActive { get; private set; }

        public virtual User User { get; set; }
        public virtual List<AlertConfigurationPlatform> AlertConfigurationPlatforms { get; set; }
    }
}
