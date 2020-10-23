using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public  partial class CustomerPagedQueryResponse : ICustomerPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ICustomer> Results { get; set;}
    }
}
