﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotApis.Models
{
    public class User
    {
        public int Id { get; set; }

        public long DiscordId { get; set; }

        public string Username { get; set; }

        public ushort DiscriminatorValue { get; set; }

        public List<GuildUser> UserGuilds { get; set; }
    }
}
