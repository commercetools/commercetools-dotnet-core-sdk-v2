using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDiscountSetMessagePayload : IOrderLineItemDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public IMoney TotalPrice { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }
        public IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        public OrderLineItemDiscountSetMessagePayload()
        {
            this.Type = "OrderLineItemDiscountSet";
        }
    }
}
