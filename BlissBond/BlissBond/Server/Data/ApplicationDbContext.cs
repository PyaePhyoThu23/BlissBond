using BlissBond.Server.Configurations.Entities;
using BlissBond.Server.Models;
using BlissBond.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlissBond.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Your model configuration here
            modelBuilder.Entity<Match>()
                .HasOne(m => m.User1)
                .WithMany() // Assuming you don't have a navigation property for this relationship
                .HasForeignKey(m => m.User1Id)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cascade delete

            modelBuilder.Entity<Match>()
                .HasOne(m => m.User2)
                .WithMany() // Assuming you don't have a navigation property for this relationship
                .HasForeignKey(m => m.User2Id)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.ApplyConfiguration(new UserSeedConfigurations());
            modelBuilder.ApplyConfiguration(new MatchSeedConfigurations());
        }

        public DbSet<BlissBond.Shared.Domain.Request> Request { get; set; } = default!;
    }
}