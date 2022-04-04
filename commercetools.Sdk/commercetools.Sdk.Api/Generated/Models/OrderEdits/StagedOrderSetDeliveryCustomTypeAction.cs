using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryCustomTypeAction : IStagedOrderSetDeliveryCustomTypeAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetDeliveryCustomTypeAction()
        {
            this.Action = "setDeliveryCustomType";
        }
    }
}
