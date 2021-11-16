using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderLineItemDiscountSetMessagePayload : IOrderLineItemDiscountSetMessagePayload
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
