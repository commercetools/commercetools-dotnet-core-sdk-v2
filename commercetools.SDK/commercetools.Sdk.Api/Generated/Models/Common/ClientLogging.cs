using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Common
{
    public partial class ClientLogging 
    {
        public string ClientId { get; set;}
        
        public string ExternalUserId { get; set;}
        
        public CustomerReference Customer { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
