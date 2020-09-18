using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("addAddress")]
    public class CustomerAddAddressAction : CustomerUpdateAction
    {
        public Address Address { get; set;}
    }
}
