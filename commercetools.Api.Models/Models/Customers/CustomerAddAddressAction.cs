using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerAddAddressAction : CustomerUpdateAction
    {
        public Address Address { get; set;}
    }
}
