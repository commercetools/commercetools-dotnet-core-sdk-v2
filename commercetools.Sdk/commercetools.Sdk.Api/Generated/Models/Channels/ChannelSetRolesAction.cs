using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Channels
{
    public partial class ChannelSetRolesAction : IChannelSetRolesAction
    {
        public string Action { get; set; }

        public List<IChannelRoleEnum> Roles { get; set; }
        public ChannelSetRolesAction()
        {
            this.Action = "setRoles";
        }
    }
}
