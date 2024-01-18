using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchRequest))]
    public partial interface IProductSearchRequest
    {
        IProductSearchQuery Query { get; set; }

        IProductSearchQuery PostFilter { get; set; }

        IList<IProductSearchSorting> Sort { get; set; }
        IEnumerable<IProductSearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        int? Limit { get; set; }

        int? Offset { get; set; }

        bool? MarkMatchingVariants { get; set; }

        IProductSearchProjectionParams Projection { get; set; }

        IList<IProductSearchFacetExpression> Facets { get; set; }
        IEnumerable<IProductSearchFacetExpression> FacetsEnumerable { set => Facets = value.ToList(); }


    }
}
