using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    public class ChannelDraft 
    {
        public string Key { get; set;}
        
        public List<ChannelRoleEnum> Roles { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public Address Address { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public GeoJson GeoLocation { get; set;}
    }
}
