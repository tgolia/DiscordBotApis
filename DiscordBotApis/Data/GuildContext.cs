using DiscordBotApis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data
{
    public class GuildContext : DbContext
    {
        public DbSet<Guild> Guilds { get; set; }

        public GuildContext(DbContextOptions options)
            : base(options) { }
    }
}