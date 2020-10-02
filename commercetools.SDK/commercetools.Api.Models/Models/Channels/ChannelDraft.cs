using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelDraft 
    {
        public string Key { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public Address Address { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public GeoJson GeoLocation { get; set;}
    }
}
