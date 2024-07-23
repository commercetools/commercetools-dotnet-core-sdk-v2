using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelDraft : IChannelDraft
    {
        public string Key { get; set; }

        public IList<IChannelRoleEnum> Roles { get; set; }
        public IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IBaseAddress Address { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IGeoJson GeoLocation { get; set; }
    }
}
