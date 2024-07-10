using commercetools.Sdk.Api.Models.CartDiscounts;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeChangeCartDiscountsAction : IDiscountCodeChangeCartDiscountsAction
    {
        public string Action { get; set; }

        public IList<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        public IEnumerable<ICartDiscountResourceIdentifier> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }

        public DiscountCodeChangeCartDiscountsAction()
        {
            this.Action = "changeCartDiscounts";
        }
    }
}
