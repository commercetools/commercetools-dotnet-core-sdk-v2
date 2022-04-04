using System;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetValidFromAndUntilAction : ICartDiscountSetValidFromAndUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
        public CartDiscountSetValidFromAndUntilAction()
        {
            this.Action = "setValidFromAndUntil";
        }
    }
}
