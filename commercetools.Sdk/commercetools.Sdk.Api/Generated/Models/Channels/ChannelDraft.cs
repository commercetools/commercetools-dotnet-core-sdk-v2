using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public  partial class ChannelDraft : IChannelDraft
    {
        public string Key { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public IAddress Address { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IGeoJson GeoLocation { get; set;}
    }
}
