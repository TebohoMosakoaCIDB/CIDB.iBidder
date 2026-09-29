using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CIDB.iBidder.Domain.Models.Csd
{
    public class CommodityLocations
    {
        [XmlElement("WardCode")]
        public List<string> WardCodes { get; set; } = [];
    }
}
