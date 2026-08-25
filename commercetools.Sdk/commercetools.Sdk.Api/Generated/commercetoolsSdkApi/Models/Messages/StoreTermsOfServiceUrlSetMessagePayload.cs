

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreTermsOfServiceUrlSetMessagePayload : IStoreTermsOfServiceUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string TermsOfServiceUrl { get; set; }
        public StoreTermsOfServiceUrlSetMessagePayload()
        {
            this.Type = "StoreTermsOfServiceUrlSet";
        }
    }
}
