using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public IMoney Value { get; set; }

        public IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
        public IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
