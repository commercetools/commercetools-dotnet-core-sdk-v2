using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction))]
    public partial interface IChannelAddRolesAction : IChannelUpdateAction
    {
        IList<IChannelRoleEnum> Roles { get; set; }
        IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


    }
}
