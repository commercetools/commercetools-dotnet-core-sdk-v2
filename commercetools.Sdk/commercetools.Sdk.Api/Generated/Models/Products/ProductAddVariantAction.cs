using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductAddVariantAction : IProductAddVariantAction
    {
        public string Action { get; set; }

        public string Sku { get; set; }

        public string Key { get; set; }

        public List<IEmbeddedPriceDraft> Prices { get; set; }

        public List<IImage> Images { get; set; }

        public List<IAttribute> Attributes { get; set; }

        public bool? Staged { get; set; }

        public List<IAsset> Assets { get; set; }
        public ProductAddVariantAction()
        {
            this.Action = "addVariant";
        }
    }
}
