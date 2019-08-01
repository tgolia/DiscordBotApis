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
                //Name = "Bongus"
            };

            var guildList = new List<Guild>() { guild };

            return guildList;
        }

        public Guild GetGuildById(ulong id)
        {
            var guild = new Guild()
            {
                //Name = "BongusById"
            };

            return guild;
        }

        public List<User> GetUsersByGuildId(int guildId)
        {
            var user = new User()
            {
                //Name = "BongusUser"
            };

            var userList = new List<User>() { user };

            return userList;
        }
    }
}