using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetBillingAddressCustomTypeAction : IStagedOrderSetBillingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetBillingAddressCustomTypeAction()
        {
            this.Action = "setBillingAddressCustomType";
        }
    }
}
