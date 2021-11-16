using commercetools.Api.Models.ApiClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Api.Models.ApiClients.ApiClientPagedQueryResponse))]
    public partial interface IApiClientPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Offset { get; set;}
        
        long Count { get; set;}
        
        long? Total { get; set;}
        
        List<IApiClient> Results { get; set;}
    }
}
