using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelSetRolesAction))]
    public partial interface IChannelSetRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set; }
    }
}
