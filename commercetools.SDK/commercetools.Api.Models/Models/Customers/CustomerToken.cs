using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerToken 
    {
        public string Id { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public string CustomerId { get; set;}
        
        public DateTime ExpiresAt { get; set;}
        
        public string Value { get; set;}
    }
}
