using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeShippingAddressId")]
    public partial class MyCustomerRemoveShippingAddressIdAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerRemoveShippingAddressIdAction()
        { 
           this.Action = "removeShippingAddressId";
        }
    }
}
