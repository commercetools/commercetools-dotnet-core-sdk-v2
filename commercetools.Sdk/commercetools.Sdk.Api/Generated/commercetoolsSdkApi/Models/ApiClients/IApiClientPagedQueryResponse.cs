using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApiClients.ApiClientPagedQueryResponse))]
    public partial interface IApiClientPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IApiClient> Results { get; set; }

        IEnumerable<IApiClient> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
