using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removeLineItem")]
    public partial class CartRemoveLineItemAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public Money ExternalPrice { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
        public CartRemoveLineItemAction()
        { 
           this.Action = "removeLineItem";
        }
    }
}
