using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotifyBot.Domain.Models.Entities;

namespace NotifyBot.Data.MySql.Maps
{
    public class AlertConfigurationPlatformMap : BaseMap<AlertConfigurationPlatform>
    {
        public AlertConfigurationPlatformMap() : base("alert_configuration_platform") { }

        public override void Configure(EntityTypeBuilder<AlertConfigurationPlatform> builder)
        {
            builder.Property(x => x.AlertPlatform)
                .IsRequired();

            builder.Property(x => x.AlertConfigurationId)
                .IsRequired();

            builder.HasOne(x => x.AlertConfiguration)
                .WithMany(x => x.AlertConfigurationPlatforms)
                .HasForeignKey(x => x.AlertConfigurationId)
                .IsRequired();

            builder.HasIndex(x => x.AlertConfigurationId);

            base.Configure(builder);
        }
    }
}
