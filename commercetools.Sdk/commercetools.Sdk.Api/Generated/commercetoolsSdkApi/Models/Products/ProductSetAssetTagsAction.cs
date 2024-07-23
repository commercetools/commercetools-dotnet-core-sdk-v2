using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetAssetTagsAction : IProductSetAssetTagsAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<string> Tags { get; set; }
        public IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }

        public ProductSetAssetTagsAction()
        {
            this.Action = "setAssetTags";
        }
    }
}
