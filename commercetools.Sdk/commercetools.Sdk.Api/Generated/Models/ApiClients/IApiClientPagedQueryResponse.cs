using commercetools.Sdk.Api.Models.ApiClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
