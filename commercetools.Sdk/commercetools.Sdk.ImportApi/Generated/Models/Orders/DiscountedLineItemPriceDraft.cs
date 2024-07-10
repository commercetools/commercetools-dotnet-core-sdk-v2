using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set; }

        public IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
        public IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
