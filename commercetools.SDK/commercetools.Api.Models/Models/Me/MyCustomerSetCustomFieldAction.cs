using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomField")]
    public class MyCustomerSetCustomFieldAction : MyCustomerUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
