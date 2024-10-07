using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetAssetSourcesAction : IProductSetAssetSourcesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<IAssetSource> Sources { get; set; }

        public IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }
        public ProductSetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}
