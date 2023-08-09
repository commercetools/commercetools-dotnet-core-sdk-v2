using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDirectDiscountsAction : IStagedOrderSetDirectDiscountsAction
    {
        public string Action { get; set; }

        public IList<IDirectDiscountDraft> Discounts { get; set; }
        public IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }

        public StagedOrderSetDirectDiscountsAction()
        {
            this.Action = "setDirectDiscounts";
        }
    }
}
