using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetShippingAddressAction : IOrderSetShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public OrderSetShippingAddressAction()
        {
            this.Action = "setShippingAddress";
        }
    }
}
