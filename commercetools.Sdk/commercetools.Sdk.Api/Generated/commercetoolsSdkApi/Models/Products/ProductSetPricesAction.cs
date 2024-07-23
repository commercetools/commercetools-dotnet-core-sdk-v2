using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPricesAction : IProductSetPricesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public IList<IPriceDraft> Prices { get; set; }
        public IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        public bool? Staged { get; set; }
        public ProductSetPricesAction()
        {
            this.Action = "setPrices";
        }
    }
}
