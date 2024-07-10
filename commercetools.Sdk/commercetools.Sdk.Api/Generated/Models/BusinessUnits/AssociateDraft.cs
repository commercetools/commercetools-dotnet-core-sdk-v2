using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateDraft : IAssociateDraft
    {
        public IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        public ICustomerResourceIdentifier Customer { get; set; }
    }
}
