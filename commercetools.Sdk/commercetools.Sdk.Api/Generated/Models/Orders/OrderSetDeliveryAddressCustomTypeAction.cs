using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetDeliveryAddressCustomTypeAction : IOrderSetDeliveryAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetDeliveryAddressCustomTypeAction()
        {
            this.Action = "setDeliveryAddressCustomType";
        }
    }
}
