using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelAddRolesAction))]
    public partial interface IChannelAddRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set;}
    }
}
