using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setBillingAddress")]
    public partial class MyCartSetBillingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
        public MyCartSetBillingAddressAction()
        { 
           this.Action = "setBillingAddress";
        }
    }
}
