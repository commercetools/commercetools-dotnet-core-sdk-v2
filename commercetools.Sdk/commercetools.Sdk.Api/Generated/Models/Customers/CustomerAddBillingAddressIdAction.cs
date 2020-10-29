using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerAddBillingAddressIdAction : ICustomerAddBillingAddressIdAction
    {
        public string Action { get; set;}
        
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public CustomerAddBillingAddressIdAction()
        { 
           this.Action = "addBillingAddressId";
        }
    }
}
