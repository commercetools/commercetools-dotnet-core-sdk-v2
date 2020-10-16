using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeAddress")]
    public partial class MyCustomerRemoveAddressAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        public MyCustomerRemoveAddressAction()
        { 
           this.Action = "removeAddress";
        }
    }
}
