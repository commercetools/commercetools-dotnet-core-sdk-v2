

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetTermsOfServiceUrlAction : IStoreSetTermsOfServiceUrlAction
    {
        public string Action { get; set; }

        public string TermsOfServiceUrl { get; set; }
        public StoreSetTermsOfServiceUrlAction()
        {
            this.Action = "setTermsOfServiceUrl";
        }
    }
}
