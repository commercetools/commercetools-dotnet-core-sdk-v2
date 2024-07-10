using System;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetItemShippingAddressCustomFieldAction : ICartSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetItemShippingAddressCustomFieldAction()
        {
            this.Action = "setItemShippingAddressCustomField";
        }
    }
}
