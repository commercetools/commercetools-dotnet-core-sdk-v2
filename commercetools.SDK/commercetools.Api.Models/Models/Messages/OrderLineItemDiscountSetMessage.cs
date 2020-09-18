using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderLineItemDiscountSet")]
    public class OrderLineItemDiscountSetMessage : Message
    {
        public string LineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public Money TotalPrice { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
    }
}
