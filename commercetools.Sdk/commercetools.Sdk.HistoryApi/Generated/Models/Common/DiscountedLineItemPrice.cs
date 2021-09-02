using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class DiscountedLineItemPrice : IDiscountedLineItemPrice
    {
        public IMoney Value { get; set; }

        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
