using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetDirectDiscountsAction : IMyCartSetDirectDiscountsAction
    {
        public string Action { get; set; }

        public IList<IDirectDiscountDraft> Discounts { get; set; }
        public IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }

        public MyCartSetDirectDiscountsAction()
        {
            this.Action = "setDirectDiscounts";
        }
    }
}
