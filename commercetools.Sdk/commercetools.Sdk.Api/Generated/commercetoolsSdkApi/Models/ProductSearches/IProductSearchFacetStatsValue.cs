using commercetools.Sdk.Api.Models.Searches;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetStatsValue))]
    public partial interface IProductSearchFacetStatsValue
    {
        string Name { get; set; }

        IProductSearchFacetScopeEnum Scope { get; set; }

        ISearchQuery Filter { get; set; }

        string Field { get; set; }

        ISearchFieldType FieldType { get; set; }

    }
}
