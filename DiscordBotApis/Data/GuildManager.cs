using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;

namespace DiscordBotApis.Data
{
    public class GuildManager : IGuildRepository
    {
        private GuildContext _guildContext;

        public GuildManager(GuildContext context)
        {
            _guildContext = context;
        }

        public Guild GetGuildById(ulong id)

        {
            Console.WriteLine(_guildContext.Guilds);
            return _guildContext.Guilds
                .FirstOrDefault(g => g.GuildId == id);
        }

        public List<Guild> GetGuilds()
        {
            return _guildContext.Guilds.ToList();
        }

        //public List<User> GetUsersByGuildId(int guildId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}