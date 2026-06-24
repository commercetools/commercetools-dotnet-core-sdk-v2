using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodAddStoreAction : IShippingMethodAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public ShippingMethodAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}
