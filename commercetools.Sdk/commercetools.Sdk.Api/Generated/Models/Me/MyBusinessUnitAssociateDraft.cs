using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAssociateDraft : IMyBusinessUnitAssociateDraft
    {
        public long Version { get; set; }

        public IMyCustomerDraft Customer { get; set; }

        public IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }

    }
}
