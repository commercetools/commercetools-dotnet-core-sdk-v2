

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetCookiePolicyUrlAction : IStoreSetCookiePolicyUrlAction
    {
        public string Action { get; set; }

        public string CookiePolicyUrl { get; set; }
        public StoreSetCookiePolicyUrlAction()
        {
            this.Action = "setCookiePolicyUrl";
        }
    }
}
