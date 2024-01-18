using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetCountValue))]
    public partial interface IProductSearchFacetCountValue
    {
        string Name { get; set; }

        IProductSearchFacetEnumScope Scope { get; set; }

        IProductSearchQuery Filter { get; set; }

        IProductSearchFacetEnumCount Level { get; set; }

    }
}
