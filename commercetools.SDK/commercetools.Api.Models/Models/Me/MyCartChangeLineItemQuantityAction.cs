using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeLineItemQuantity")]
    public partial class MyCartChangeLineItemQuantityAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public double Quantity { get; set;}
        
        public Money ExternalPrice { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public MyCartChangeLineItemQuantityAction()
        { 
           this.Action = "changeLineItemQuantity";
        }
    }
}
