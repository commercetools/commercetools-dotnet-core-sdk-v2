using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("setCustomField")]
    public class CustomerGroupSetCustomFieldAction : CustomerGroupUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
