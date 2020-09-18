using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomLineItemDiscountSet")]
    public class OrderCustomLineItemDiscountSetMessage : Message
    {
        public string CustomLineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
    }
}
