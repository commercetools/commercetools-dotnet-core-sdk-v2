using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set;}
        
        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
