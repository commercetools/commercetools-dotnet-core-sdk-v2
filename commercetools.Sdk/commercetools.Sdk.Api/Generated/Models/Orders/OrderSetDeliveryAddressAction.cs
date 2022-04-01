using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetDeliveryAddressAction : IOrderSetDeliveryAddressAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public IBaseAddress Address { get; set; }
        public OrderSetDeliveryAddressAction()
        {
            this.Action = "setDeliveryAddress";
        }
    }
}
