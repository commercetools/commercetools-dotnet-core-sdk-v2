using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("changeAddress")]
    public partial class CustomerChangeAddressAction : CustomerUpdateAction
    {
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        
        public Address Address { get; set;}
        public CustomerChangeAddressAction()
        { 
           this.Action = "changeAddress";
        }
    }
}
