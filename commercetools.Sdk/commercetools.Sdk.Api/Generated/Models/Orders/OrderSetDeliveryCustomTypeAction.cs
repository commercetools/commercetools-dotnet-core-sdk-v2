using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetDeliveryCustomTypeAction : IOrderSetDeliveryCustomTypeAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetDeliveryCustomTypeAction()
        {
            this.Action = "setDeliveryCustomType";
        }
    }
}
