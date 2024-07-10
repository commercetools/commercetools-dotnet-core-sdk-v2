using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateRoleAssignmentDraft : IAssociateRoleAssignmentDraft
    {
        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }

        public IAssociateRoleInheritanceMode Inheritance { get; set; }
    }
}
