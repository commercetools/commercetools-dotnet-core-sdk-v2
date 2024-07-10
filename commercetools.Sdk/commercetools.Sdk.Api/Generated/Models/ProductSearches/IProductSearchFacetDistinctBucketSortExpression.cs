using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetDistinctBucketSortExpression))]
    public partial interface IProductSearchFacetDistinctBucketSortExpression
    {
        IProductSearchFacetDistinctBucketSortBy By { get; set; }

        ISearchSortOrder Order { get; set; }

    }
}
