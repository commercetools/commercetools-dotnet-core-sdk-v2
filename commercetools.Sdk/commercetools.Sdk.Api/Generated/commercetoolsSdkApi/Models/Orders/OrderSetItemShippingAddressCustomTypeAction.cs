using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetItemShippingAddressCustomTypeAction : IOrderSetItemShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetItemShippingAddressCustomTypeAction()
        {
            this.Action = "setItemShippingAddressCustomType";
        }
    }
}
