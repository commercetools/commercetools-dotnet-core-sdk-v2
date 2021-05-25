using System.ComponentModel.DataAnnotations;

namespace commercetools.Base.Client
{
    public class ClientConfiguration : IClientConfiguration
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string Scope { get; set; }

        public string ProjectKey { get; set; }

        /// <summary>
        /// Authorization Base Address Url like: "https://auth.europe-west1.gcp.commercetools.com/"
        /// </summary>
        [RegularExpression(@"^.*/$", ErrorMessage = "ClientConfiguration AuthorizationBaseAddress URI should end with slash.")]
        public string AuthorizationBaseAddress { get; set; } = "https://auth.europe-west1.gcp.commercetools.com/";

        /// <summary>
        /// Api Base Address Url like: "https://api.europe-west1.gcp.commercetools.com/"
        /// </summary>
        [RegularExpression(@"^.*/$", ErrorMessage = "ClientConfiguration ApiBaseAddress URI should end with slash.")]
        public string ApiBaseAddress { get; set; } = "https://api.europe-west1.gcp.commercetools.com/";
    }
}
