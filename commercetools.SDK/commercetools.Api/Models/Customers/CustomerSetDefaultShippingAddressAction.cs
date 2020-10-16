using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setDefaultShippingAddress")]
    public partial class CustomerSetDefaultShippingAddressAction : CustomerUpdateAction
    {
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public CustomerSetDefaultShippingAddressAction()
        { 
           this.Action = "setDefaultShippingAddress";
        }
    }
}
