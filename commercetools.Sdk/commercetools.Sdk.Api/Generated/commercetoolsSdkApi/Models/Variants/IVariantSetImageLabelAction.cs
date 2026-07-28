using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetImageLabelAction))]
    public partial interface IVariantSetImageLabelAction : IVariantUpdateAction
    {
        string ImageUrl { get; set; }

        string Label { get; set; }

        bool? Staged { get; set; }

    }
}
