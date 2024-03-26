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

        int Offset { get; set; }

        int Limit { get; set; }

        IList<IProductSearchFacetResult> Facets { get; set; }
        IEnumerable<IProductSearchFacetResult> FacetsEnumerable { set => Facets = value.ToList(); }


        IList<IProductSearchResult> Results { get; set; }
        IEnumerable<IProductSearchResult> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
