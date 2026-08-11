using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetKeyAction))]
    public partial interface IVariantSetAssetKeyAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

    }
}
