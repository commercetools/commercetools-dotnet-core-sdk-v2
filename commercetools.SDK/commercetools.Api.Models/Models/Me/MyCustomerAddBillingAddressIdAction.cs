using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addBillingAddressId")]
    public partial class MyCustomerAddBillingAddressIdAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerAddBillingAddressIdAction()
        { 
           this.Action = "addBillingAddressId";
        }
    }
}
