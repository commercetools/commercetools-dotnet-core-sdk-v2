

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetContactUrlAction : IStoreSetContactUrlAction
    {
        public string Action { get; set; }

        public string ContactUrl { get; set; }
        public StoreSetContactUrlAction()
        {
            this.Action = "setContactUrl";
        }
    }
}
