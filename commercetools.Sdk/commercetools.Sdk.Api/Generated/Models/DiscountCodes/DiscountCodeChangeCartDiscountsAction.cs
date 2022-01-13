using commercetools.Api.Models.CartDiscounts;
using System.Collections.Generic;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeChangeCartDiscountsAction : IDiscountCodeChangeCartDiscountsAction
    {
        public string Action { get; set; }

        public List<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        public DiscountCodeChangeCartDiscountsAction()
        {
            this.Action = "changeCartDiscounts";
        }
    }
}
