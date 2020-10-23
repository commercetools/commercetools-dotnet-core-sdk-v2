using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyCartUpdateItemShippingAddressAction : IMyCartUpdateItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IAddress Address { get; set;}
        public MyCartUpdateItemShippingAddressAction()
        { 
           this.Action = "updateItemShippingAddress";
        }
    }
}
