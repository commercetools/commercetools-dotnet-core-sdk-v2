

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetImprintUrlAction : IStoreSetImprintUrlAction
    {
        public string Action { get; set; }

        public string ImprintUrl { get; set; }
        public StoreSetImprintUrlAction()
        {
            this.Action = "setImprintUrl";
        }
    }
}
