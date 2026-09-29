namespace CIDB.iBidder.Application.TransferOptions.Ocds
{
    public class OcdsPartyDetailsDto
    {
        public string? Url { get; set; }

        public string? BuyerProfile { get; set; }

        public List<OcdsClassificationDto> Classifications { get; set; } = [];
    }
}
