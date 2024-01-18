using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetDistinctStartsWith))]
    public partial interface IProductSearchFacetDistinctStartsWith
    {
        string Value { get; set; }

        bool CaseInsensitive { get; set; }

    }
}
