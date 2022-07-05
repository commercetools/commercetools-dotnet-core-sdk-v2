using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelRemoveRolesAction : IChannelRemoveRolesAction
    {
        public string Action { get; set; }

        public List<IChannelRoleEnum> Roles { get; set; }
        public ChannelRemoveRolesAction()
        {
            this.Action = "removeRoles";
        }
    }
}
