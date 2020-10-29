using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemPriceAction : ICartSetLineItemPriceAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        public CartSetLineItemPriceAction()
        { 
           this.Action = "setLineItemPrice";
        }
    }
}
