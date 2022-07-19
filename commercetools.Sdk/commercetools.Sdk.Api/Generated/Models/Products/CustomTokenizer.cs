using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class CustomTokenizer : ICustomTokenizer
    {
        public string Type { get; set; }

        public List<string> Inputs { get; set; }
        public CustomTokenizer()
        {
            this.Type = "custom";
        }
    }
}