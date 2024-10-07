using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetOrderAction))]
    public partial interface IProductTailoringChangeAssetOrderAction : IProductTailoringUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

        IList<string> AssetOrder { get; set; }

        IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }

    }
}
