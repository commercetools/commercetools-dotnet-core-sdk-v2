using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.DiscountedLineItemPrice))]
    public partial interface IDiscountedLineItemPrice
    {
        IMoney Value { get; set; }

        List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
