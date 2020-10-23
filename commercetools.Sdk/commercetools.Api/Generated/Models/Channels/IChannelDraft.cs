using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Channels
{
    public interface IChannelDraft 
    {
        string Key { get; set;}
        
        List<string> Roles { get; set;}
        
        List<ChannelRoleEnum> RolesAsEnum { get; }
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        IAddress Address { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IGeoJson GeoLocation { get; set;}
    }
}
