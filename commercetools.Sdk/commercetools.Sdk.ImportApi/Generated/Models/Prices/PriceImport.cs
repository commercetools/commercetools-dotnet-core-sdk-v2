using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Prices
{
    public partial class PriceImport : IPriceImport
    {
        public string Key { get; set;}
        
        public ITypedMoney Value { get; set;}
        
        public string Country { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public ICustomerGroupKeyReference CustomerGroup { get; set;}
        
        public IChannelKeyReference Channel { get; set;}
        
        public IDiscountedPrice Discounted { get; set;}
        
        public bool? Publish { get; set;}
        
        public List<IPriceTier> Tiers { get; set;}
        
        public ICustom Custom { get; set;}
        
        public IProductVariantKeyReference ProductVariant { get; set;}
        
        public IProductKeyReference Product { get; set;}
    }
}
