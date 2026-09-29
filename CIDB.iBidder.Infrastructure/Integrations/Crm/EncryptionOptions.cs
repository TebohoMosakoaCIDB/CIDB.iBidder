using System;
using System.Collections.Generic;
using System.Text;

namespace CIDB.iBidder.Infrastructure.Integrations.Crm
{
    public class EncryptionOptions
    {
        public const string SectionName = "Encryption";
        public required string Key { get; set; }
        public required string IV { get; set; }
    }
}
