using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction))]
    public partial interface IProductChangeAssetOrderAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

        IList<string> AssetOrder { get; set; }

        IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }

    }
}
