using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomTypeAction))]
    public partial interface IVariantSetAssetCustomTypeAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
