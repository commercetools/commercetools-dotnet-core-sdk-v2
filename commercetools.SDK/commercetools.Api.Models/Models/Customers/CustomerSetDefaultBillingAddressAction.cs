using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setDefaultBillingAddress")]
    public partial class CustomerSetDefaultBillingAddressAction : CustomerUpdateAction
    {
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public CustomerSetDefaultBillingAddressAction()
        { 
           this.Action = "setDefaultBillingAddress";
        }
    }
}
