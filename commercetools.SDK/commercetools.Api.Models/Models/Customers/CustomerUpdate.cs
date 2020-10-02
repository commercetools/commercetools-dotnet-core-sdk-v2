using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerUpdate 
    {
        public long Version { get; set;}
        
        public List<CustomerUpdateAction> Actions { get; set;}
    }
}
