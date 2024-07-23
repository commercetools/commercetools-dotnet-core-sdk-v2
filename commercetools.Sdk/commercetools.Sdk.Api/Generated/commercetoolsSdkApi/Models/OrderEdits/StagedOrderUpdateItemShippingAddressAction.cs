using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderUpdateItemShippingAddressAction : IStagedOrderUpdateItemShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public StagedOrderUpdateItemShippingAddressAction()
        {
            this.Action = "updateItemShippingAddress";
        }
    }
}
