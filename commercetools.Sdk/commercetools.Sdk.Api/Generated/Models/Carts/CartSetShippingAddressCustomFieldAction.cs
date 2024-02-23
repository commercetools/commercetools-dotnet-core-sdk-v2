using System;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingAddressCustomFieldAction : ICartSetShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetShippingAddressCustomFieldAction()
        {
            this.Action = "setShippingAddressCustomField";
        }
    }
}
