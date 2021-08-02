using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ProductVariantChannelAvailability))]
    public partial interface IProductVariantChannelAvailability 
    {
        bool IsOnStock { get; set;}
        
        int RestockableInDays { get; set;}
        
        int AvailableQuantity { get; set;}
    }
}