

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetCheckoutUrlTemplateAction : IStoreSetCheckoutUrlTemplateAction
    {
        public string Action { get; set; }

        public string CheckoutUrlTemplate { get; set; }
        public StoreSetCheckoutUrlTemplateAction()
        {
            this.Action = "setCheckoutUrlTemplate";
        }
    }
}
