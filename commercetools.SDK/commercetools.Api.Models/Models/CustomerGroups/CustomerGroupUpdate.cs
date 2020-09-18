using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupUpdate 
    {
        public long Version { get; set;}
        
        public List<CustomerGroupUpdateAction> Actions { get; set;}
    }
}
