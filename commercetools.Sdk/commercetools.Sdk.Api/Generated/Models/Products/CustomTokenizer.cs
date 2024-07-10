using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class CustomTokenizer : ICustomTokenizer
    {
        public string Type { get; set; }

        public IList<string> Inputs { get; set; }
        public IEnumerable<string> InputsEnumerable { set => Inputs = value.ToList(); }

        public CustomTokenizer()
        {
            this.Type = "custom";
        }
    }
}
