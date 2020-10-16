using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addShippingAddressId")]
    public partial class MyCustomerAddShippingAddressIdAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerAddShippingAddressIdAction()
        { 
           this.Action = "addShippingAddressId";
        }
    }
}
