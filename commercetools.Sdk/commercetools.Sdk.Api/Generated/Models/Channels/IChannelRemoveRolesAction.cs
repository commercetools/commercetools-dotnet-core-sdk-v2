using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelRemoveRolesAction))]
    public partial interface IChannelRemoveRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set;}
    }
}
