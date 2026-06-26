using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantChangeAssetNameAction))]
    public partial interface IVariantChangeAssetNameAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        ILocalizedString Name { get; set; }

    }
}
