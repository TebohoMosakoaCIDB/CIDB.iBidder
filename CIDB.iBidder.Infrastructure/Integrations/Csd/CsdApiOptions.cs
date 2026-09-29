using System;
using System.Collections.Generic;
using System.Text;

namespace CIDB.iBidder.Infrastructure.Integrations.Csd
{
    public class CsdApiOptions
    {
        public const string SectionName = "Csd";

        public required string BaseUrl { get; set; }

        public string AuthenticateEndpoint { get; set; }
            = "Authenticate";

        public string SupplierDetailsEndpoint { get; set; }
            = "Supplier/GetSupplierDetailsFull";

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int TimeoutSeconds { get; set; } = 60;
        public string CidbAccreditationBodyCode { get; set; } = "CIDB";
    }
}
