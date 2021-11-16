using System.Collections.Generic;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelAddRolesAction : IChannelAddRolesAction
    {
        public string Action { get; set; }

        public List<IChannelRoleEnum> Roles { get; set; }
        public ChannelAddRolesAction()
        {
            this.Action = "addRoles";
        }
    }
}
