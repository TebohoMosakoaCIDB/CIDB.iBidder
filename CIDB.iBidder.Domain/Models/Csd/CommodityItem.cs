using System.Xml.Serialization;

namespace CIDB.iBidder.Domain.Models.Csd
{
    public class CommodityItem
    {
        [XmlElement("CommodityCode")]
        public string? CommodityCode { get; set; }
    }
}
