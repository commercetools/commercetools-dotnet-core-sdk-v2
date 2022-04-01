using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class OrderCustomLineItemDiscountSetMessagePayload : IOrderCustomLineItemDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public string CustomLineItemId { get; set; }

        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }
        public OrderCustomLineItemDiscountSetMessagePayload()
        {
            this.Type = "OrderCustomLineItemDiscountSet";
        }
    }
}
