using commercetools.Sdk.Api.Models.Products;
using System;

namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchResult : IProductSearchResult
    {
        public string Id { get; set; }

        public IProductSearchMatchingVariants MatchingVariants { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IProductProjection ProductProjection { get; set; }
    }
}
