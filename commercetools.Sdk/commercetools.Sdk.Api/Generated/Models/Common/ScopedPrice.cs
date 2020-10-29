using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class ScopedPrice : IScopedPrice
    {
        public string Id { get; set;}
        
        public ITypedMoney Value { get; set;}
        
        public ITypedMoney CurrentValue { get; set;}
        
        public string Country { get; set;}
        
        public ICustomerGroupReference CustomerGroup { get; set;}
        
        public IChannelReference Channel { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public IDiscountedPrice Discounted { get; set;}
        
        public ICustomFields Custom { get; set;}
    }
}
