using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchResult : IProductSearchResult
    {
        public string Id { get; set; }

        public IProductProjection ProductProjection { get; set; }

        public IProductSearchMatchingVariants MatchingVariants { get; set; }
    }
}
