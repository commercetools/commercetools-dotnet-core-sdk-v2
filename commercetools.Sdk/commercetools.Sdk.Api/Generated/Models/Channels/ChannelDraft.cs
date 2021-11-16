using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelDraft : IChannelDraft
    {
        public string Key { get; set;}
        
        public List<IChannelRoleEnum> Roles { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public IBaseAddress Address { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IGeoJson GeoLocation { get; set;}
    }
}
