using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingAddressAction : IStagedOrderSetShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public StagedOrderSetShippingAddressAction()
        {
            this.Action = "setShippingAddress";
        }
    }
}
