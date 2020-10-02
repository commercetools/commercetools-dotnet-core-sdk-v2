using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class ScopedPrice 
    {
        public string Id { get; set;}
        
        public TypedMoney Value { get; set;}
        
        public TypedMoney CurrentValue { get; set;}
        
        public string Country { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public ChannelReference Channel { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public DiscountedPrice Discounted { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
