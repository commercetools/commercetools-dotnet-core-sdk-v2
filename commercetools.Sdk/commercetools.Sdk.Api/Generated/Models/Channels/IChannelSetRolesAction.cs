using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetRolesAction))]
    public partial interface IChannelSetRolesAction : IChannelUpdateAction
    {
        List<IChannelRoleEnum> Roles { get; set; }
    }
}
