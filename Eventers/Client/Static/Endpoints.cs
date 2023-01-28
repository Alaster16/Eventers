using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventers.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string EventeesEndpoint = $"{Prefix}/Eventees";
        public static readonly string PaymentsEndpoint = $"{Prefix}/Payments";
        public static readonly string EventersEndpoint = $"{Prefix}/Eventers";
        public static readonly string CompaniesEndpoint = $"{Prefix}/Companies";
        public static readonly string StaffsEndpoint = $"{Prefix}/Staffs";

    }
}
