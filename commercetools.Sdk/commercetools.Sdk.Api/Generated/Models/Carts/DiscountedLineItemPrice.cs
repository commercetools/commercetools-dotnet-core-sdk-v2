using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public ITypedMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
