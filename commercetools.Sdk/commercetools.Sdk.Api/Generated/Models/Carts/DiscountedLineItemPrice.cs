using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public ITypedMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
