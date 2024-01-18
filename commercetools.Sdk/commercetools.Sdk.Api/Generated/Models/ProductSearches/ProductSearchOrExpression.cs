using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchOrExpression : IProductSearchOrExpression
    {
        public IList<IProductSearchQuery> Or { get; set; }
        public IEnumerable<IProductSearchQuery> OrEnumerable { set => Or = value.ToList(); }

    }
}
