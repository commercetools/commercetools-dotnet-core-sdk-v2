using System;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetAssetCustomFieldAction : IProductSetAssetCustomFieldAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ProductSetAssetCustomFieldAction()
        {
            this.Action = "setAssetCustomField";
        }
    }
}
