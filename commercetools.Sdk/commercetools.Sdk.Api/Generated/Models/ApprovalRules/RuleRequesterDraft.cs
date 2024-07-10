using commercetools.Sdk.Api.Models.AssociateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class RuleRequesterDraft : IRuleRequesterDraft
    {
        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }
    }
}
