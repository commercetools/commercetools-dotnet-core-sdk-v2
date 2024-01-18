using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetResult : IProductSearchFacetResult
    {
        public IList<IProductSearchFacetResultExpression> Results { get; set; }
        public IEnumerable<IProductSearchFacetResultExpression> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
