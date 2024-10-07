

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class WhitespaceTokenizer : IWhitespaceTokenizer
    {
        public string Type { get; set; }
        public WhitespaceTokenizer()
        {
            this.Type = "whitespace";
        }
    }
}
