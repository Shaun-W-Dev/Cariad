using System.Globalization;

namespace Cariad.Domain.Models
{
    public class CaresScreenModel
    {
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Slug => FormatSlug(Code);
        public string Category { get; set; } = string.Empty;

        protected static string FormatSlug(string code)
        {
            if (code is null) return string.Empty;
            return $"/{code.ToLower(CultureInfo.CurrentCulture)}";
        }
    }
}
