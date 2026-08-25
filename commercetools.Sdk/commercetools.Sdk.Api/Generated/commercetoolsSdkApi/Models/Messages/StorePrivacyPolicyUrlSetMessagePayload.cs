

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StorePrivacyPolicyUrlSetMessagePayload : IStorePrivacyPolicyUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string PrivacyPolicyUrl { get; set; }
        public StorePrivacyPolicyUrlSetMessagePayload()
        {
            this.Type = "StorePrivacyPolicyUrlSet";
        }
    }
}
