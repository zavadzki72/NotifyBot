using NotifyBot.Domain.Models.Enumerators;

namespace NotifyBot.Domain.Models.Entities
{
    public class AlertConfigurationPlatform : BaseEntity
    {
        public AlertConfigurationPlatform(int alertConfigurationId, AlertPlatform alertPlatform)
        {
            AlertConfigurationId = alertConfigurationId;
            AlertPlatform = alertPlatform;
        }

        public int AlertConfigurationId { get; private set; }
        public AlertPlatform AlertPlatform { get; private set; }

        public AlertConfiguration AlertConfiguration { get; set; }
    }
}
