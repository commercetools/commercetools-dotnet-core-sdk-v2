using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceDiscountsSetMessagePayload : IProductPriceDiscountsSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
        public IEnumerable<IProductPriceDiscountsSetUpdatedPrice> UpdatedPricesEnumerable { set => UpdatedPrices = value.ToList(); }

        public ProductPriceDiscountsSetMessagePayload()
        {
            this.Type = "ProductPriceDiscountsSet";
        }
    }
}
