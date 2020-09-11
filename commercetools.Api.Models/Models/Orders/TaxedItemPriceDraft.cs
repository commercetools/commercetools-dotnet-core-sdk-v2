using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class TaxedItemPriceDraft 
    {
        public Money TotalNet { get; set;}
        
        public Money TotalGross { get; set;}
    }
}
