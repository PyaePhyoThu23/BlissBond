using BlissBond.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlissBond.Server.Configurations.Entities
{
    public class UserSeedConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Dean",
                    LastName = "Winchester",
                    Gender = "M",
                    Bio = "I am handsome",
                    Nickname = null,
                    Location = "Jurong East",
                    Popularity = 3.5,
                    Password = "1234",
                    Email = "deana@gmail.com"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Marry",
                    LastName = "Tan",
                    Gender = "F",
                    Bio = "I am smart",
                    Nickname = "haha",
                    Location = "Jurong West",
                    Popularity = 5,
                    Password = "5678",
                    Email = "marry@gmail.com"
                }

                );
        }
    }
}
