using System;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApiClients.ApiClient))]
    public partial interface IApiClient
    {
        string Id { get; set; }

        string Name { get; set; }

        string Scope { get; set; }

        string Secret { get; set; }

        Date? LastUsedAt { get; set; }

        DateTime? DeleteAt { get; set; }

        DateTime? CreatedAt { get; set; }

        int? AccessTokenValiditySeconds { get; set; }

        int? RefreshTokenValiditySeconds { get; set; }

    }
}
