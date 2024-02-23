using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetShippingAddressCustomTypeAction : IOrderSetShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetShippingAddressCustomTypeAction()
        {
            this.Action = "setShippingAddressCustomType";
        }
    }
}
