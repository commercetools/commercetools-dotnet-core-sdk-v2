using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.CartClassificationTier))]
    public partial interface ICartClassificationTier : IShippingRatePriceTier
    {
        string Value { get; set;}
        
        IMoney Price { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
        
        bool? IsMatching { get; set;}
    }
}
