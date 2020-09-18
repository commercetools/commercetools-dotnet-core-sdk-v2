using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeBillingAddressId")]
    public class MyCustomerRemoveBillingAddressIdAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
    }
}
