﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LCU.NET.LeagueClient;

namespace LCU.NET.Plugins.LoL
{
    public static class Matchmaking
    {
        [APIMethod("/lol-matchmaking/v1/ready-check", Method.GET)]
        public static Task<LolMatchmakingMatchmakingReadyCheckResource> GetReadyCheck()
            => MakeRequestAsync<LolMatchmakingMatchmakingReadyCheckResource>();

        [APIMethod("/lol-matchmaking/v1/ready-check/accept", Method.POST)]
        public static Task PostReadyCheckAccept()
            => MakeRequestAsync();

        [APIMethod("/lol-matchmaking/v1/ready-check/decline", Method.POST)]
        public static Task PostReadyCheckDecline()
            => MakeRequestAsync();
    }
}