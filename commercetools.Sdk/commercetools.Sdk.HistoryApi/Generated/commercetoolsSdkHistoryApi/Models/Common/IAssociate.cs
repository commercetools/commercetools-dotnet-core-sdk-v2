using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Associate))]
    public partial interface IAssociate
    {
        IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        IReference Customer { get; set; }

    }
}
