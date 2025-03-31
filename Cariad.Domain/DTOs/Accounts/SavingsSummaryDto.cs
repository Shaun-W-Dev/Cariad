namespace Cariad.Domain.DTOs.Accounts
{
    public record SavingsSummaryDto
    {
        public int SavingsId { get; set; }
        public int AccountNumber { get; set; }
        public string? Name { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal ClearedBalance { get; set; }
    }
}
