using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentProductsNotFoundWarning : IAgentProductsNotFoundWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> Products { get; set; }

        public IEnumerable<string> ProductsEnumerable { set => Products = value.ToList(); }
        public AgentProductsNotFoundWarning()
        {
            this.Code = "ProductsNotFound";
        }
    }
}
