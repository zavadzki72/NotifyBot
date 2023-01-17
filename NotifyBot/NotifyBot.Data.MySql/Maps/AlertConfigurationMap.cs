using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotifyBot.Domain.Models.Entities;

namespace NotifyBot.Data.MySql.Maps
{
    public class AlertConfigurationMap : BaseMap<AlertConfiguration>
    {
        public AlertConfigurationMap() : base("alert_configuration") { }

        public override void Configure(EntityTypeBuilder<AlertConfiguration> builder)
        {
            builder.Property(x => x.AlertType)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.AlertConfigurations)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            builder.HasIndex(x => x.UserId);

            base.Configure(builder);
        }

    }
}
