namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderRemoveItemShippingAddressAction : IStagedOrderRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public StagedOrderRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
