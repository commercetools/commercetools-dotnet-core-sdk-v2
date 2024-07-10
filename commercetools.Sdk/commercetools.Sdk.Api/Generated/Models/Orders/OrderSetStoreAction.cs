using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetStoreAction : IOrderSetStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public OrderSetStoreAction()
        {
            this.Action = "setStore";
        }
    }
}
