using commercetools.Api.Models.Channels;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Common
{
    public partial class Price : IPrice
    {
        public string Id { get; set;}
        
        public ITypedMoney Value { get; set;}
        
        public string Country { get; set;}
        
        public ICustomerGroupReference CustomerGroup { get; set;}
        
        public IChannelReference Channel { get; set;}
        
        public DateTime? ValidFrom { get; set;}
        
        public DateTime? ValidUntil { get; set;}
        
        public IDiscountedPrice Discounted { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public List<IPriceTier> Tiers { get; set;}
    }
}
