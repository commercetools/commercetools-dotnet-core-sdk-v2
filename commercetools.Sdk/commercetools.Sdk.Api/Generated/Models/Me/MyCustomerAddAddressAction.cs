using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerAddAddressAction : IMyCustomerAddAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public MyCustomerAddAddressAction()
        { 
           this.Action = "addAddress";
        }
    }
}
