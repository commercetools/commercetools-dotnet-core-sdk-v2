using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderLineItemDiscountSet")]
    public partial class OrderLineItemDiscountSetMessage : Message
    {
        public string LineItemId { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public Money TotalPrice { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        public OrderLineItemDiscountSetMessage()
        { 
           this.Type = "OrderLineItemDiscountSet";
        }
    }
}
