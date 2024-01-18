using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetBucketResult))]
    public partial interface IProductSearchFacetBucketResult : IProductSearchFacetResultExpression
    {
        IList<IProductSearchFacetResultBucket> Buckets { get; set; }
        IEnumerable<IProductSearchFacetResultBucket> BucketsEnumerable { set => Buckets = value.ToList(); }


    }
}
