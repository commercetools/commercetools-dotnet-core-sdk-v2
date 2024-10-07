using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction))]
    public partial interface IProductTailoringRemoveVariantAction : IProductTailoringUpdateAction
    {
        long? Id { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

    }
}
