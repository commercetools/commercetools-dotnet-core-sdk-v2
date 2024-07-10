using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetDistinctBucketSortExpression : IProductSearchFacetDistinctBucketSortExpression
    {
        public IProductSearchFacetDistinctBucketSortBy By { get; set; }

        public ISearchSortOrder Order { get; set; }
    }
}
