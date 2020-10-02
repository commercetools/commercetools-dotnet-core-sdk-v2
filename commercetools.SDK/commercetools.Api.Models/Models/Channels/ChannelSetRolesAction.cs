using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setRoles")]
    public partial class ChannelSetRolesAction : ChannelUpdateAction
    {
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        public ChannelSetRolesAction()
        { 
           this.Action = "setRoles";
        }
    }
}
