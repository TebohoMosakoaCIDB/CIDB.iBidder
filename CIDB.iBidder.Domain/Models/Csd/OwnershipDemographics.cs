using System.Xml.Serialization;

namespace CIDB.iBidder.Domain.Models.Csd
{
    public class OwnershipDemographics
    {
        [XmlElement("OwnershipDemographic")]
        public List<OwnershipDemographic> Items { get; set; } = [];
    }
}
