using DiscordBotApis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data
{
    public class DiscordBotApiDbContext : DbContext
    {
        public DbSet<Guild> Guilds { get; set; }

        public DiscordBotApiDbContext(DbContextOptions options)
            : base(options) { }
    }
}