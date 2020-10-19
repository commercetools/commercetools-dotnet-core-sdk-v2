using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDefaultShippingAddress")]
    public partial class MyCustomerSetDefaultShippingAddressAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerSetDefaultShippingAddressAction()
        { 
           this.Action = "setDefaultShippingAddress";
        }
    }
}
