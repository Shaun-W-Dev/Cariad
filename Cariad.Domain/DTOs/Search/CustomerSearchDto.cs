namespace Cariad.Domain.DTOs.Search
{
    public record CustomerSearchDto(string? AccountNumber, string? CustomerNumber, string? UserId, string? Forename, string? Surname, string? DateOfBirth, string? Postcode);
}