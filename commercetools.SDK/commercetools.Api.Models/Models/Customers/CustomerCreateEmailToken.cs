using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerCreateEmailToken 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
