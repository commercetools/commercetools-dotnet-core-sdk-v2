using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addItemShippingAddress")]
    public partial class MyCartAddItemShippingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
        public MyCartAddItemShippingAddressAction()
        { 
           this.Action = "addItemShippingAddress";
        }
    }
}
