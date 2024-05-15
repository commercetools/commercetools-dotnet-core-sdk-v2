using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResultBucketEntry))]
    public partial interface IProductSearchFacetResultBucketEntry
    {
        string Key { get; set; }

        int Count { get; set; }

    }
}
