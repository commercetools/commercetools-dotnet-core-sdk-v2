using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class TaxedItemPriceDraft : ITaxedItemPriceDraft
    {
        public IMoney TotalNet { get; set;}
        
        public IMoney TotalGross { get; set;}
    }
}
