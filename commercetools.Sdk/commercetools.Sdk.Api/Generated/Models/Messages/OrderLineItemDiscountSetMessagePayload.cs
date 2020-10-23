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
    public  partial class OrderLineItemDiscountSetMessagePayload : IOrderLineItemDiscountSetMessagePayload
    {
        public string Type { get; set;}
        
        public string LineItemId { get; set;}
        
        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public IMoney TotalPrice { get; set;}
        
        public ITaxedItemPrice TaxedPrice { get; set;}
        public OrderLineItemDiscountSetMessagePayload()
        { 
           this.Type = "OrderLineItemDiscountSet";
        }
    }
}
