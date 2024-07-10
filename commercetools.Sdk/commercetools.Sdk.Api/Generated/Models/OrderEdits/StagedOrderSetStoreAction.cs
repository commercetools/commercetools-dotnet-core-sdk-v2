using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetStoreAction : IStagedOrderSetStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public StagedOrderSetStoreAction()
        {
            this.Action = "setStore";
        }
    }
}
