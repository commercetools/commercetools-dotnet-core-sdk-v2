using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("addShippingAddressId")]
    public partial class CustomerAddShippingAddressIdAction : CustomerUpdateAction
    {
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public CustomerAddShippingAddressIdAction()
        { 
           this.Action = "addShippingAddressId";
        }
    }
}
