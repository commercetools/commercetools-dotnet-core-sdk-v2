using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFilterExpression : IProductSearchFilterExpression
    {
        public IList<IProductSearchQueryExpression> Filter { get; set; }
        public IEnumerable<IProductSearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }

    }
}
