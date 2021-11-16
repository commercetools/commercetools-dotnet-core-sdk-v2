using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerAddShippingAddressIdAction : IMyCustomerAddShippingAddressIdAction
    {
        public string Action { get; set;}
        
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public MyCustomerAddShippingAddressIdAction()
        { 
           this.Action = "addShippingAddressId";
        }
    }
}
