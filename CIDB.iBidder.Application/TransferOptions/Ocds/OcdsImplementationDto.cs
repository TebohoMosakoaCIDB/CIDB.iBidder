using System.Text.Json.Serialization;

namespace CIDB.iBidder.Application.TransferOptions.Ocds
{
    public class OcdsImplementationDto
    {
        [JsonPropertyName("transcations")]
        public List<OcdsTransactionDto> Transactions { get; set; } = [];

        public List<OcdsMilestoneDto> Milestones { get; set; } = [];

        public List<OcdsDocumentDto> Documents { get; set; } = [];
    }
}
