using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemShippingDetailsAction : IMyCartSetLineItemShippingDetailsAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
        public MyCartSetLineItemShippingDetailsAction()
        { 
           this.Action = "setLineItemShippingDetails";
        }
    }
}
