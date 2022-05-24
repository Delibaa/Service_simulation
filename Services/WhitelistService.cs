using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Server_simulation
{
    public class WhitelistService : Whitelist.WhitelistBase
    {
        private readonly ILogger<WhitelistService> _logger;
        public WhitelistService(ILogger<WhitelistService> logger)
        {
            _logger = logger;
        }

        public override Task<WhiteListHostInfo> Get_WhiteList(GetWhitelist_request request, ServerCallContext context)
        {
            Console.Write(request.Endpoint);
            Console.Write(request.Publickey);
            Console.Write(request.Request);
            return Task.FromResult(new WhiteListHostInfo()
            {
                Endpoint = "1111111",
                Publickey = "222222",
                Time = Timestamp.FromDateTime(DateTime.UtcNow) 
            });
        }
    }
}