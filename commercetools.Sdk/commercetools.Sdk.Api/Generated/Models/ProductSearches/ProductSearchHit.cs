using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchHit : IProductSearchHit
    {
        public string Id { get; set; }

        public IProductProjection ProductProjection { get; set; }

        public IList<IProductSearchMatchingVariant> MatchingVariants { get; set; }
        public IEnumerable<IProductSearchMatchingVariant> MatchingVariantsEnumerable { set => MatchingVariants = value.ToList(); }

    }
}
