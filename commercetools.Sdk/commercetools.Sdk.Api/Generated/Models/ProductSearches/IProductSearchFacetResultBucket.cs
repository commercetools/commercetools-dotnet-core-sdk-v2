using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResultBucket))]
    public partial interface IProductSearchFacetResultBucket
    {
        string Key { get; set; }

        int Count { get; set; }

    }
}
