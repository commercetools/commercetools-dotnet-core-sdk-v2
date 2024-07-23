using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.InheritedAssociate))]
    public partial interface IInheritedAssociate
    {
        IList<IInheritedAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        IEnumerable<IInheritedAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        IReference Customer { get; set; }

    }
}
