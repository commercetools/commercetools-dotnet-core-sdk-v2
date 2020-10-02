using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomLineItemDiscountSet")]
    public partial class OrderCustomLineItemDiscountSetMessage : Message
    {
        public string CustomLineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        public OrderCustomLineItemDiscountSetMessage()
        { 
           this.Type = "OrderCustomLineItemDiscountSet";
        }
    }
}
