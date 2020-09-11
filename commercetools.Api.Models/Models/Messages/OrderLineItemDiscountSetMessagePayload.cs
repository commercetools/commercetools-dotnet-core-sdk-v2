using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderLineItemDiscountSetMessagePayload : MessagePayload
    {
        public string LineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public Money TotalPrice { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
    }
}
