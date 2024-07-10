using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Associate))]
    public partial interface IAssociate
    {
        IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        ICustomerReference Customer { get; set; }

    }
}
