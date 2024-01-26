using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlissBond.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string UsersEndpoint = $"{Prefix}/Users";

        public static readonly string MatchesEndpoint = $"{Prefix}/Matches";
        public static readonly string RequestsEndpoint = $"{Prefix}/Requests";
        public static readonly string MessagesEndpoint = $"{Prefix}/Messages";

    }
}
