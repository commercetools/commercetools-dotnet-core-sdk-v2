using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchMatchingVariant))]
    public partial interface IProductSearchMatchingVariant
    {
        int Id { get; set; }

        string Sku { get; set; }

    }
}
