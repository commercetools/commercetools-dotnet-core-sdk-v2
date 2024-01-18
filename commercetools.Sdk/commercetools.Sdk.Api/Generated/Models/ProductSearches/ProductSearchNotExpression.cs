using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchNotExpression : IProductSearchNotExpression
    {
        public IList<IProductSearchQuery> Not { get; set; }
        public IEnumerable<IProductSearchQuery> NotEnumerable { set => Not = value.ToList(); }

    }
}
