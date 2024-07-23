using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLPriceChangedError : IGraphQLPriceChangedError
    {
        public string Code { get; set; }

        public IList<string> LineItems { get; set; }
        public IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public bool Shipping { get; set; }
        public GraphQLPriceChangedError()
        {
            this.Code = "PriceChanged";
        }
    }
}
