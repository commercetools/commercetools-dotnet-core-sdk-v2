using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("removeRoles")]
    public partial class ChannelRemoveRolesAction : ChannelUpdateAction
    {
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        public ChannelRemoveRolesAction()
        { 
           this.Action = "removeRoles";
        }
    }
}
