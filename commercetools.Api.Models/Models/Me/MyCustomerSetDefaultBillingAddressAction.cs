using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCustomerSetDefaultBillingAddressAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
    }
}
