using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemShippingDetails")]
    public partial class CartSetCustomLineItemShippingDetailsAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        public CartSetCustomLineItemShippingDetailsAction()
        { 
           this.Action = "setCustomLineItemShippingDetails";
        }
    }
}
