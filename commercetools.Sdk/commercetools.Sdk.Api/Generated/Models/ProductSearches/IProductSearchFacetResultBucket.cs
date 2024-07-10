using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
