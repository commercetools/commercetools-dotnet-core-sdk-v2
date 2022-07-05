using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelDraft : IChannelDraft
    {
        public string Key { get; set; }

        public List<IChannelRoleEnum> Roles { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IBaseAddress Address { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IGeoJson GeoLocation { get; set; }
    }
}
