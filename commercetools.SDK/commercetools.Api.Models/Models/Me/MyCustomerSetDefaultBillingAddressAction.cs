using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDefaultBillingAddress")]
    public partial class MyCustomerSetDefaultBillingAddressAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerSetDefaultBillingAddressAction()
        { 
           this.Action = "setDefaultBillingAddress";
        }
    }
}
