using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDiscountSetMessagePayload : IOrderLineItemDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        public IMoney TotalPrice { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public List<IMethodTaxedPrice> TaxedPricePortions { get; set; }
        public OrderLineItemDiscountSetMessagePayload()
        {
            this.Type = "OrderLineItemDiscountSet";
        }
    }
}
