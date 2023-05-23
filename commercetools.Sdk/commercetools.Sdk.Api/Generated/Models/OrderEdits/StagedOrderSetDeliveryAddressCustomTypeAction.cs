using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDeliveryAddressCustomTypeAction : IStagedOrderSetDeliveryAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetDeliveryAddressCustomTypeAction()
        {
            this.Action = "setDeliveryAddressCustomType";
        }
    }
}
