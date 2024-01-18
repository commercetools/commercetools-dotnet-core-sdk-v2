using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchAndExpression : IProductSearchAndExpression
    {
        public IList<IProductSearchQuery> And { get; set; }
        public IEnumerable<IProductSearchQuery> AndEnumerable { set => And = value.ToList(); }

    }
}
