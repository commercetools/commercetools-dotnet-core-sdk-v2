using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerToken))]
    public partial interface ICustomerToken 
    {
        string Id { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        string CustomerId { get; set;}
        
        DateTime ExpiresAt { get; set;}
        
        string Value { get; set;}
    }
}
