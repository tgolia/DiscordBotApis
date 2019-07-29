using DiscordBotApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Data
{
    public interface IGuildRepository
    {
        List<Guild> GetGuilds();

        Guild GetGuildById(int id);

        List<User> GetUsersByGuildId(int guildId);
    }
}
