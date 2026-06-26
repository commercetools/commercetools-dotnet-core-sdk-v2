using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantAddAssetAction))]
    public partial interface IVariantAddAssetAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        IAssetDraft Asset { get; set; }

        int? Position { get; set; }

    }
}
