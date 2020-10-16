using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("addRoles")]
    public partial class ChannelAddRolesAction : ChannelUpdateAction
    {
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        public ChannelAddRolesAction()
        { 
           this.Action = "addRoles";
        }
    }
}
