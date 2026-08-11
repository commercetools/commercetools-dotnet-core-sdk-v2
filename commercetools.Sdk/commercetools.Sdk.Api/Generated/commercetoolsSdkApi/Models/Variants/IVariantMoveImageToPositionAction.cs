using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantMoveImageToPositionAction))]
    public partial interface IVariantMoveImageToPositionAction : IVariantUpdateAction
    {
        string ImageUrl { get; set; }

        long Position { get; set; }

        bool? Staged { get; set; }

    }
}
