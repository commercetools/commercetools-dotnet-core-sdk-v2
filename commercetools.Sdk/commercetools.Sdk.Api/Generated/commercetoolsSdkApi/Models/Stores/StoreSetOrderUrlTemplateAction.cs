

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetOrderUrlTemplateAction : IStoreSetOrderUrlTemplateAction
    {
        public string Action { get; set; }

        public string OrderUrlTemplate { get; set; }
        public StoreSetOrderUrlTemplateAction()
        {
            this.Action = "setOrderUrlTemplate";
        }
    }
}
