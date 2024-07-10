using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleCreatedMessagePayload : IAssociateRoleCreatedMessagePayload
    {
        public string Type { get; set; }

        public IAssociateRole AssociateRole { get; set; }
        public AssociateRoleCreatedMessagePayload()
        {
            this.Type = "AssociateRoleCreated";
        }
    }
}
