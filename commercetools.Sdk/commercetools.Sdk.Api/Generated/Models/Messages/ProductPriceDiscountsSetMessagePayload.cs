using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductPriceDiscountsSetMessagePayload : IProductPriceDiscountsSetMessagePayload
    {
        public string Type { get; set; }

        public List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
        public ProductPriceDiscountsSetMessagePayload()
        {
            this.Type = "ProductPriceDiscountsSet";
        }
    }
}
