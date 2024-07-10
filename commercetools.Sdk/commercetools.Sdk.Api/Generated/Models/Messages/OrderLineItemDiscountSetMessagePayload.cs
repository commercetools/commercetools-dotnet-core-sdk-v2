using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDiscountSetMessagePayload : IOrderLineItemDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public ICentPrecisionMoney TotalPrice { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }
        public IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        public OrderLineItemDiscountSetMessagePayload()
        {
            this.Type = "OrderLineItemDiscountSet";
        }
    }
}
