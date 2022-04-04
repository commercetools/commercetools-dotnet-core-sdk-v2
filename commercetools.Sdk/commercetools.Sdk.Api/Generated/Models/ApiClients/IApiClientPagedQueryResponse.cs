using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApiClients.ApiClientPagedQueryResponse))]
    public partial interface IApiClientPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<IApiClient> Results { get; set; }
    }
}
