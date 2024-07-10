using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductChangeAssetOrderAction : IProductChangeAssetOrderAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public IList<string> AssetOrder { get; set; }
        public IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }

        public ProductChangeAssetOrderAction()
        {
            this.Action = "changeAssetOrder";
        }
    }
}
