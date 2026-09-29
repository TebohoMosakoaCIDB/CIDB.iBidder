namespace CIDB.iBidder.Domain.Models.Csd
{
    public class IndustryClassification
    {
        public string? IndustryClassificationCode { get; set; }

        public decimal PercentageRanking { get; set; }

        public bool CoreIndustryIndicator { get; set; }
    }
}
