namespace Cariad.Domain.DTOs.Accounts
{
    public record MortageSummaryDto
    {
        public int MortageId { get; set; }
        public int AccountNumber { get; set; }
        public string? Name { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal RepaymentBalance { get; set; }
    }
}
