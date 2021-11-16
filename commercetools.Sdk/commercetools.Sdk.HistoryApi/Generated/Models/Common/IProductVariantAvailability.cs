using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ProductVariantAvailability))]
    public partial interface IProductVariantAvailability 
    {
        bool IsOnStock { get; set;}
        
        int RestockableInDays { get; set;}
        
        int AvailableQuantity { get; set;}
        
        IProductVariantChannelAvailabilityMap Channels { get; set;}
    }
}
