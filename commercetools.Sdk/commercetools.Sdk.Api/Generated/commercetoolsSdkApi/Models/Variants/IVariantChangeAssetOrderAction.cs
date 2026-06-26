using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantChangeAssetOrderAction))]
    public partial interface IVariantChangeAssetOrderAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        IList<string> AssetOrder { get; set; }

        IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }

    }
}
