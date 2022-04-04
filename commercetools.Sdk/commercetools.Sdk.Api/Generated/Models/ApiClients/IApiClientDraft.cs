using commercetools.Base.CustomAttributes;


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
