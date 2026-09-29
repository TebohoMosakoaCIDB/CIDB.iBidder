using System.Xml.Serialization;

namespace CIDB.iBidder.Application.TransferOptions.Csd
{
    [XmlRoot("GetSupplierDetailRequest")]
    public class GetSupplierDetailRequest
    {
        [XmlElement("SupplierNumber")]
        public string SupplierNumber { get; set; } = string.Empty;
    }
}
