using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomFieldAction))]
    public partial interface IVariantSetAssetCustomFieldAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
