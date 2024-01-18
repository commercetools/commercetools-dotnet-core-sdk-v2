using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductPagedSearchResponse))]
    public partial interface IProductPagedSearchResponse
    {
        long Total { get; set; }

        int? Offset { get; set; }

        int? Limit { get; set; }

        IProductSearchFacetResult Facets { get; set; }

        IList<IProductSearchHit> Hits { get; set; }
        IEnumerable<IProductSearchHit> HitsEnumerable { set => Hits = value.ToList(); }


    }
}
