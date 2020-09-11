using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ApiClients
{
    public class ApiClient 
    {
        public string Id { get; set;}
        
        public string Name { get; set;}
        
        public string Scope { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastUsedAt { get; set;}
        
        public DateTime DeleteAt { get; set;}
        
        public string Secret { get; set;}
    }
}
