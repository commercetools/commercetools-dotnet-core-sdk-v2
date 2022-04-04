namespace commercetools.Sdk.Api.Models.ApiClients
{
    public partial class ApiClientDraft : IApiClientDraft
    {
        public string Name { get; set; }

        public string Scope { get; set; }

        public long? DeleteDaysAfterCreation { get; set; }

        public int? AccessTokenValiditySeconds { get; set; }

        public int? RefreshTokenValiditySeconds { get; set; }
    }
}
