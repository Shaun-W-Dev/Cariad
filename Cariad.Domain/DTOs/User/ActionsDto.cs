namespace Cariad.Domain.DTOs.User
{
    public record ActionsDto
    {
        public int ActionId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public DateTime Created { get; set; }
        public string? Status { get; set; }
    }
}
