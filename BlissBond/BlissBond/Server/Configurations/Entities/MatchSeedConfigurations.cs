using BlissBond.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlissBond.Server.Configurations.Entities
{
    public class MatchSeedConfigurations : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> modelBuilder)
        {
            modelBuilder.HasData(
                new Match
                {
                    Id = 1,
                    MatchDate = DateTime.Now,
                    MatchStatus = "Just Friend",
                    User1Id = 1,
                    User2Id = 2,
                }
                );
        }
    }
}
