using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupUpdate 
    {
        public long Version { get; set;}
        
        public List<CustomerGroupUpdateAction> Actions { get; set;}
    }
}
