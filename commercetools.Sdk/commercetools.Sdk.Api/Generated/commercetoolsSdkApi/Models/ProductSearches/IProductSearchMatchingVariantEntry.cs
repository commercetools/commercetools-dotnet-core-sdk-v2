using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchMatchingVariantEntry))]
    public partial interface IProductSearchMatchingVariantEntry
    {
        int Id { get; set; }

        string Sku { get; set; }

    }
}
