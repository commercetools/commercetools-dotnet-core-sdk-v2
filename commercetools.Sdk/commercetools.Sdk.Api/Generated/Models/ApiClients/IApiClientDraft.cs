using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApiClients.ApiClientDraft))]
    public partial interface IApiClientDraft
    {
        string Name { get; set; }

        string Scope { get; set; }

        long? DeleteDaysAfterCreation { get; set; }

        int? AccessTokenValiditySeconds { get; set; }

        int? RefreshTokenValiditySeconds { get; set; }

    }
}
