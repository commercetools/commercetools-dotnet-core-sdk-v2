using System;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetCustomFieldAction : ICartDiscountSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartDiscountSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
