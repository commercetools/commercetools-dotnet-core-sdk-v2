using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ShippingRateDraft))]
    public partial interface IShippingRateDraft 
    {
        IMoney Price { get; set;}
        
        IMoney FreeAbove { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
