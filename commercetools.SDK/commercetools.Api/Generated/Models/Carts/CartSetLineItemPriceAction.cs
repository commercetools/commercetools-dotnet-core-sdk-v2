using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemPrice")]
    public partial class CartSetLineItemPriceAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public Money ExternalPrice { get; set;}
        public CartSetLineItemPriceAction()
        { 
           this.Action = "setLineItemPrice";
        }
    }
}
