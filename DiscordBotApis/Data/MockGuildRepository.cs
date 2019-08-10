using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordBotApis.Models;

namespace DiscordBotApis.Data
{
    public class MockGuildRepository : IGuildRepository
    {
        public List<Guild> GetGuilds()
        {
            var guild = new Guild();

            var guildList = new List<Guild>() { guild };

            return guildList;
        }

        public Guild GetGuildById(ulong id)
        {
            var guild = new Guild();

            return guild;
        }

        public List<User> GetUsersByGuildId(ulong guildId)
        {
            var user = new User();

            var userList = new List<User>() { user };

            return userList;
        }
    }
}