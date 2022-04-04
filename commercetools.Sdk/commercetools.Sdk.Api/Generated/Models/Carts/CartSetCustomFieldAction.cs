using System;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetCustomFieldAction : ICartSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
