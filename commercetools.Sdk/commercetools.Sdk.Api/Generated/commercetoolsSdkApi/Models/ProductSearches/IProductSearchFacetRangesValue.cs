using commercetools.Sdk.Api.Models.Searches;
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

        IProductSearchFacetScopeEnum Scope { get; set; }

        ISearchQuery Filter { get; set; }

        IProductSearchFacetCountLevelEnum Level { get; set; }

        string Field { get; set; }

        IList<IProductSearchFacetRangesFacetRange> Ranges { get; set; }
        IEnumerable<IProductSearchFacetRangesFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }


        string Language { get; set; }

        ISearchFieldType FieldType { get; set; }

    }
}
