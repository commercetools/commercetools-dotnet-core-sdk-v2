using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public ITypedMoney Value { get; set; }

        public IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
        public IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
