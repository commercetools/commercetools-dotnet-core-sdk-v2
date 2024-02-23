using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetItemShippingAddressCustomTypeAction : IStagedOrderSetItemShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetItemShippingAddressCustomTypeAction()
        {
            this.Action = "setItemShippingAddressCustomType";
        }
    }
}
