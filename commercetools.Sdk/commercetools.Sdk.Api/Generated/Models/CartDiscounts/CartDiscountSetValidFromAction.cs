using System;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetValidFromAction : ICartDiscountSetValidFromAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }
        public CartDiscountSetValidFromAction()
        {
            this.Action = "setValidFrom";
        }
    }
}
