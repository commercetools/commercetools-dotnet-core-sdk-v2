using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomLineItemDiscountSet")]
    public partial class OrderCustomLineItemDiscountSetMessagePayload : MessagePayload
    {
        public string CustomLineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        public OrderCustomLineItemDiscountSetMessagePayload()
        { 
           this.Type = "OrderCustomLineItemDiscountSet";
        }
    }
}
