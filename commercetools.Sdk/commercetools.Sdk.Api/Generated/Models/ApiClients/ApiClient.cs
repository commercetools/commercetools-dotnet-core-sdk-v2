using System;


namespace commercetools.Api.Models.ApiClients
{
    public partial class ApiClient : IApiClient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Scope { get; set; }

        public string Secret { get; set; }

        public DateTime? LastUsedAt { get; set; }

        public DateTime? DeleteAt { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? AccessTokenValiditySeconds { get; set; }

        public int? RefreshTokenValiditySeconds { get; set; }
    }
}
