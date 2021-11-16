using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ShippingRate))]
    public partial interface IShippingRate 
    {
        IMoney Price { get; set;}
        
        IMoney FreeAbove { get; set;}
        
        bool IsMatching { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
