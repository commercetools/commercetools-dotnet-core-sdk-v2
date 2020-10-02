using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("addAddress")]
    public partial class CustomerAddAddressAction : CustomerUpdateAction
    {
        public Address Address { get; set;}
        public CustomerAddAddressAction()
        { 
           this.Action = "addAddress";
        }
    }
}
