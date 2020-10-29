using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    public partial class ApiClient : IApiClient
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
