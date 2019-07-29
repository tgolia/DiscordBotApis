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
            var guild = new Guild()
            {
                //Name = "MockGuild"
            };

            var guildList = new List<Guild>() { guild };

            return guildList;
        }

        public Guild GetGuildById(int id)
        {
            var guild = new Guild()
            {
                //Name = "MockGuildById"
            };

            return guild;
        }

        public List<User> GetUsersByGuildId(int guildId)
        {
            var user = new User()
            {
                //Name = "MockUser"
            };

            var userList = new List<User>() { user };

            return userList;
        }
    }
}
