using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantRemoveImageAction))]
    public partial interface IVariantRemoveImageAction : IVariantUpdateAction
    {
        string ImageUrl { get; set; }

        bool? Staged { get; set; }

    }
}
