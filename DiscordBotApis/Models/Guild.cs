using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class Guild
    {
        //public string Name { get; set; }
        public ulong GuildId { get; set; }
        public ulong OwnerId { get; set; }
    }
}