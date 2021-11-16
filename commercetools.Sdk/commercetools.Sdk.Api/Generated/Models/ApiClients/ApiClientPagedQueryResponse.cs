using commercetools.Api.Models.ApiClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    public partial class ApiClientPagedQueryResponse : IApiClientPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Offset { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public List<IApiClient> Results { get; set;}
    }
}
