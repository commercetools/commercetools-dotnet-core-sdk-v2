using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.TaxedItemPriceDraft))]
    public interface ITaxedItemPriceDraft 
    {
        IMoney TotalNet { get; set;}
        
        IMoney TotalGross { get; set;}
    }
}
