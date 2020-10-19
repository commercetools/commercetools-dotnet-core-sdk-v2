using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Orders
{
    public partial class DiscountedLineItemPriceDraft 
    {
        public Money Value { get; set;}
        
        public List<DiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
