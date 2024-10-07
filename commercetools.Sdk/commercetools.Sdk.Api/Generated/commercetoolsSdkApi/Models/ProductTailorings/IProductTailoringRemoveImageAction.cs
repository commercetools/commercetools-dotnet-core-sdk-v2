using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveImageAction))]
    public partial interface IProductTailoringRemoveImageAction : IProductTailoringUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string ImageUrl { get; set; }

        bool? Staged { get; set; }

    }
}
