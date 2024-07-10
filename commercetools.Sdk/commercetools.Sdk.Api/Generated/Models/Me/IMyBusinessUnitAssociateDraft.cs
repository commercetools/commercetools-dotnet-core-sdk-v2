using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAssociateDraft))]
    public partial interface IMyBusinessUnitAssociateDraft
    {
        long Version { get; set; }

        IMyCustomerDraft Customer { get; set; }

        IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


    }
}
