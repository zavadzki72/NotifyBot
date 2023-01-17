using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotifyBot.Domain.Models.Entities;

namespace NotifyBot.Data.MySql.Maps
{
    public class UserMap : BaseMap<User>
    {
        public UserMap() : base("user") { }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired();

            builder.HasIndex(x => x.Name);

            base.Configure(builder);
        }
    }
}
