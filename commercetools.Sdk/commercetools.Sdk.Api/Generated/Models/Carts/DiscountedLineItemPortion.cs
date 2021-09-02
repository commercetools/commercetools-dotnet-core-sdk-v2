using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public ICartDiscountReference Discount { get; set; }

        public ITypedMoney DiscountedAmount { get; set; }
    }
}
