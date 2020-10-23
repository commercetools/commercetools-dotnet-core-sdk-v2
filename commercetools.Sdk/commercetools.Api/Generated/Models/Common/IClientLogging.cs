using commercetools.Api.Generated.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IClientLogging 
    {
        string ClientId { get; set;}
        
        string ExternalUserId { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        string AnonymousId { get; set;}
    }
}
