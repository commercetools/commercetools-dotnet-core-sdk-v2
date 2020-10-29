using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerUpdate : ICustomerUpdate
    {
        public long Version { get; set;}
        
        public List<ICustomerUpdateAction> Actions { get; set;}
    }
}
