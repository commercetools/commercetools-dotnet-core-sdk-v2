using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetSkuAction))]
    public partial interface IVariantSetSkuAction : IVariantUpdateAction
    {
        string Sku { get; set; }

        bool? Staged { get; set; }

    }
}
