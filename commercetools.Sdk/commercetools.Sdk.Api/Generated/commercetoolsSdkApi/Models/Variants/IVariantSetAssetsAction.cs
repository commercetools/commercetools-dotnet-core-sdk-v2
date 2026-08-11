using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetsAction))]
    public partial interface IVariantSetAssetsAction : IVariantUpdateAction
    {
        IList<IAssetDraft> Assets { get; set; }

        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

        bool? Staged { get; set; }

    }
}
