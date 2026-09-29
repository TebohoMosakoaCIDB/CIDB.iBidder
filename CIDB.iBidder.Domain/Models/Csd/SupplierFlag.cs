using System;
using System.Collections.Generic;
using System.Text;

namespace CIDB.iBidder.Domain.Models.Csd
{
    public class SupplierFlag
    {
        public string? SupplierFlagType { get; set; }

        public string? SupplierFlagDescription { get; set; }

        public bool SupplierFlagValue { get; set; }

        public DateTime? SupplierFlagLastVerificationDate { get; set; }

        public string? SupplierFlagDetails { get; set; }
    }
}
