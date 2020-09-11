using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupSetCustomFieldAction : CustomerGroupUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
