using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTotalPrice")]
    public partial class CartSetLineItemTotalPriceAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public CartSetLineItemTotalPriceAction()
        { 
           this.Action = "setLineItemTotalPrice";
        }
    }
}
