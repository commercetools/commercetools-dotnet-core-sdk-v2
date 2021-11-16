using System.Collections.Generic;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelRemoveRolesAction : IChannelRemoveRolesAction
    {
        public string Action { get; set;}
        
        public List<IChannelRoleEnum> Roles { get; set;}
        public ChannelRemoveRolesAction()
        { 
           this.Action = "removeRoles";
        }
    }
}
