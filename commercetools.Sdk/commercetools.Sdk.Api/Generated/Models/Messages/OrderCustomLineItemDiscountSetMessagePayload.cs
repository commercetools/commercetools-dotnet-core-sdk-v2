using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderCustomLineItemDiscountSetMessagePayload : IOrderCustomLineItemDiscountSetMessagePayload
    {
        public string Type { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public ITaxedItemPrice TaxedPrice { get; set;}
        public OrderCustomLineItemDiscountSetMessagePayload()
        { 
           this.Type = "OrderCustomLineItemDiscountSet";
        }
    }
}
