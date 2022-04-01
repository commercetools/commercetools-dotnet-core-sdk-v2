using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction))]
    public partial interface IChannelRemoveRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set; }
    }
}
