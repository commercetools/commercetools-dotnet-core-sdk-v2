using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodRemoveStoreAction : IShippingMethodRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public ShippingMethodRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}
