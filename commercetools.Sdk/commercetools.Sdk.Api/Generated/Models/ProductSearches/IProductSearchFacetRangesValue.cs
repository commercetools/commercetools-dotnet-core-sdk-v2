using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetRangesValue))]
    public partial interface IProductSearchFacetRangesValue
    {
        string Name { get; set; }

        IProductSearchFacetEnumScope Scope { get; set; }

        IProductSearchQuery Filter { get; set; }

        IProductSearchFacetEnumCount Count { get; set; }

        string Field { get; set; }

        IList<IProductSearchFacetRangesFacetRange> Ranges { get; set; }
        IEnumerable<IProductSearchFacetRangesFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }


        string Language { get; set; }

        IProductSearchAttributeType AttributeType { get; set; }

    }
}
