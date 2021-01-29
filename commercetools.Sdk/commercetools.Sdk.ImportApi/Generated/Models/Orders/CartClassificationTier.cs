using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class CartClassificationTier : ICartClassificationTier
    {
        public IShippingRateTierType Type { get; set;}
        
        public string Value { get; set;}
        
        public IMoney Price { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
        
        public bool? IsMatching { get; set;}
        public CartClassificationTier()
        { 
           this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
