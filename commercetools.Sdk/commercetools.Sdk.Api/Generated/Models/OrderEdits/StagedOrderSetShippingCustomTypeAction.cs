using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingCustomTypeAction : IStagedOrderSetShippingCustomTypeAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetShippingCustomTypeAction()
        {
            this.Action = "setShippingCustomType";
        }
    }
}
