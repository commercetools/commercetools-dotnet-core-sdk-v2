using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class ProductChangeAssetOrderAction : IProductChangeAssetOrderAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public List<string> AssetOrder { get; set; }
        public ProductChangeAssetOrderAction()
        {
            this.Action = "changeAssetOrder";
        }
    }
}
