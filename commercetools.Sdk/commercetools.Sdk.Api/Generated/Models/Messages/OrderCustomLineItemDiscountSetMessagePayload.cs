using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomLineItemDiscountSetMessagePayload : IOrderCustomLineItemDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public string CustomLineItemId { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public ITaxedItemPrice TaxedPrice { get; set; }
        public OrderCustomLineItemDiscountSetMessagePayload()
        {
            this.Type = "OrderCustomLineItemDiscountSet";
        }
    }
}
