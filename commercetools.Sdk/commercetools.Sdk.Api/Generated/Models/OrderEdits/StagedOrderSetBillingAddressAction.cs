using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetBillingAddressAction : IStagedOrderSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public StagedOrderSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
