using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscordBotApis.Data
{
    public class GuildRepository : IGuildRepository
    {
        private DiscordBotApisDbContext _context;

        public GuildRepository(DiscordBotApisDbContext context)
        {
            _context = context;
        }

        public List<Guild> GetGuilds()
        {
            var guilds = _context.Guilds.ToList();

            return guilds;
        }

        public Guild GetGuildById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByGuildId(int guildId)
        {
            throw new NotImplementedException();
        }
    }
}
