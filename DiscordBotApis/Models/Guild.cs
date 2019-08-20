using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class Guild
    {
        public int Id { get; set; }

        /// <summary>
        /// The date that the guild was created according to Discord.
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        public ulong GuildId { get; set; }

        public string GuildName { get; set; }

        public ulong OwnerId { get; set; }

        public List<GuildUser> GuildUsers { get; set; }
    }
}