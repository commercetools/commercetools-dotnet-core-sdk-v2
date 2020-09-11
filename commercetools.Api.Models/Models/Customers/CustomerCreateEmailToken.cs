using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerCreateEmailToken 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
