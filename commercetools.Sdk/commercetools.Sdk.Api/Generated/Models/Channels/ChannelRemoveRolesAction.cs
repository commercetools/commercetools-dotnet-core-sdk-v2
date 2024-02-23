using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelRemoveRolesAction : IChannelRemoveRolesAction
    {
        public string Action { get; set; }

        public IList<IChannelRoleEnum> Roles { get; set; }
        public IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }

        public ChannelRemoveRolesAction()
        {
            this.Action = "removeRoles";
        }
    }
}
