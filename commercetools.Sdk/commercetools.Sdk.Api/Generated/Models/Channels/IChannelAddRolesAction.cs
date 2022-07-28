using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction))]
    public partial interface IChannelAddRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set; }

    }
}
