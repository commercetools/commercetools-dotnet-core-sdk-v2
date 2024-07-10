using commercetools.Sdk.Api.Models.ProductSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResultBucket))]
    public partial interface IProductSearchFacetResultBucket : IProductSearchFacetResult
    {
        IList<IProductSearchFacetResultBucketEntry> Buckets { get; set; }
        IEnumerable<IProductSearchFacetResultBucketEntry> BucketsEnumerable { set => Buckets = value.ToList(); }


    }
}
