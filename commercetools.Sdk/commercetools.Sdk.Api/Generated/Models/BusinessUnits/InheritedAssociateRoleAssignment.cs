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

    public partial class InheritedAssociateRoleAssignment : IInheritedAssociateRoleAssignment
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IBusinessUnitKeyReference Source { get; set; }
    }
}
