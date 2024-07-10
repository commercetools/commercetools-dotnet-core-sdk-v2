using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set; }

        public IList<IDiscountedLineItemPortionDraft> IncludedDiscounts { get; set; }
        public IEnumerable<IDiscountedLineItemPortionDraft> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
