using System;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetLineItemCustomFieldAction : ICartSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
