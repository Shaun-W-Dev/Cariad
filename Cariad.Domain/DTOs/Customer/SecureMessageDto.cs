namespace Cariad.Domain.DTOs.Customer
{
    public record SecureMessageDto
    {
        public int MessageId { get; set; }
        public string? From { get; set; }
        public string? Subject { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime LastReply { get; set; }
    }
}
