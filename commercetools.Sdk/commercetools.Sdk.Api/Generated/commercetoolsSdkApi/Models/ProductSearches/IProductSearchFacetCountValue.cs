using commercetools.Sdk.Api.Models.Searches;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetCountValue))]
    public partial interface IProductSearchFacetCountValue
    {
        string Name { get; set; }

        IProductSearchFacetScopeEnum Scope { get; set; }

        ISearchQuery Filter { get; set; }

        IProductSearchFacetCountLevelEnum Level { get; set; }

    }
}
