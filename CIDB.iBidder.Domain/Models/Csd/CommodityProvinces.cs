using System.Xml.Serialization;

namespace CIDB.iBidder.Domain.Models.Csd
{
    public class CommodityProvinces
    {
        [XmlElement("ProvinceCode")]
        public List<string> ProvinceCodes { get; set; } = [];
    }
}
