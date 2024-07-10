using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class InheritedAssociate : IInheritedAssociate
    {
        public IList<IInheritedAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        public IEnumerable<IInheritedAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        public IReference Customer { get; set; }
    }
}
