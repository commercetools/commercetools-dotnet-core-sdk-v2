using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryAddressAction : IStagedOrderSetDeliveryAddressAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public IBaseAddress Address { get; set; }
        public StagedOrderSetDeliveryAddressAction()
        {
            this.Action = "setDeliveryAddress";
        }
    }
}
