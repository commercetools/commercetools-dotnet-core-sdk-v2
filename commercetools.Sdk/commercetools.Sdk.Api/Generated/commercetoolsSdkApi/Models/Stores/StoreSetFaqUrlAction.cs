

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetFaqUrlAction : IStoreSetFaqUrlAction
    {
        public string Action { get; set; }

        public string FaqUrl { get; set; }
        public StoreSetFaqUrlAction()
        {
            this.Action = "setFaqUrl";
        }
    }
}
