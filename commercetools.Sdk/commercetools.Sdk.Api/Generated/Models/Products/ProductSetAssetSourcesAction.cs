using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetAssetSourcesAction : IProductSetAssetSourcesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public List<IAssetSource> Sources { get; set; }
        public ProductSetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}
