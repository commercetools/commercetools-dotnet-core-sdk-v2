using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("setKey")]
    public class CustomerGroupSetKeyAction : CustomerGroupUpdateAction
    {
        public string Key { get; set;}
    }
}
