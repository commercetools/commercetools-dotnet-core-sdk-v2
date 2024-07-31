using System;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetValidUntilAction : ICartDiscountSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public CartDiscountSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
