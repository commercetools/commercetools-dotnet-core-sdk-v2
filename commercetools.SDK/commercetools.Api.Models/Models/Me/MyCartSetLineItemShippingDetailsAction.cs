using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLineItemShippingDetails")]
    public partial class MyCartSetLineItemShippingDetailsAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        public MyCartSetLineItemShippingDetailsAction()
        { 
           this.Action = "setLineItemShippingDetails";
        }
    }
}
