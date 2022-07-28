using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPricesAction : IProductSetPricesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public List<IEmbeddedPriceDraft> Prices { get; set; }

        public bool? Staged { get; set; }
        public ProductSetPricesAction()
        {
            this.Action = "setPrices";
        }
    }
}
