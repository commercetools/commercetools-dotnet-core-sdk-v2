

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderRemoveItemShippingAddressAction : IOrderRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public OrderRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
