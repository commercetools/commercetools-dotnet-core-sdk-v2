using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public  partial class CustomerGroupUpdate : ICustomerGroupUpdate
    {
        public long Version { get; set;}
        
        public List<ICustomerGroupUpdateAction> Actions { get; set;}
    }
}
