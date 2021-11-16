using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class DiscountedLineItemPriceDraft : IDiscountedLineItemPriceDraft
    {
        public IMoney Value { get; set;}
        
        public List<IDiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
