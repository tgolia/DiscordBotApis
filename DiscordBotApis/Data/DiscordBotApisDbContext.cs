using DiscordBotApis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data
{
    public class DiscordBotApisDbContext : DbContext
    {
        public DiscordBotApisDbContext(DbContextOptions<DiscordBotApisDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Guild> Guilds { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuildUser>()
                .HasKey(g => new { g.GuildId, g.UserId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
