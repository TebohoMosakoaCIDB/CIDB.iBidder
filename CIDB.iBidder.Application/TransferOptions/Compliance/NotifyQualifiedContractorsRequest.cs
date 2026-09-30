namespace CIDB.iBidder.Application.TransferOptions.Compliance
{
    public sealed class NotifyQualifiedContractorsRequest
    {
        public Guid? ProvinceId { get; set; }
        public Guid? ClassOfWorkTypeId { get; set; }
        public string? RequiredGradingDesignationContains { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
    }
}
