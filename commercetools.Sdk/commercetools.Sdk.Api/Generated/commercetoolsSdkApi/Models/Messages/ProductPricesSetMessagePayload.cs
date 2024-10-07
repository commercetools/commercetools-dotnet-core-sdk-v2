using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPricesSetMessagePayload : IProductPricesSetMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IList<IPrice> Prices { get; set; }

        public IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }

        public bool Staged { get; set; }
        public ProductPricesSetMessagePayload()
        {
            this.Type = "ProductPricesSet";
        }
    }
}
