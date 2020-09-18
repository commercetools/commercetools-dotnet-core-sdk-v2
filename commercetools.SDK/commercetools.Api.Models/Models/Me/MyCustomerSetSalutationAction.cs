using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setSalutation")]
    public class MyCustomerSetSalutationAction : MyCustomerUpdateAction
    {
        public string Salutation { get; set;}
    }
}
