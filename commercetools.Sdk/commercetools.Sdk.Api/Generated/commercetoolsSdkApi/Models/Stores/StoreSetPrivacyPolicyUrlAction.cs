

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetPrivacyPolicyUrlAction : IStoreSetPrivacyPolicyUrlAction
    {
        public string Action { get; set; }

        public string PrivacyPolicyUrl { get; set; }
        public StoreSetPrivacyPolicyUrlAction()
        {
            this.Action = "setPrivacyPolicyUrl";
        }
    }
}
