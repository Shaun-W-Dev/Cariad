namespace Cariad.API.Options
{
    public class ApiSettingsOptions
    {
        public System.Uri? BaseUrl { get; set; }
        public string ClientId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty;
        public string AuthorizationToken { get; set; } = string.Empty;
    }
}
