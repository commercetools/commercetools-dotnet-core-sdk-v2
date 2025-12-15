using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomerGroupAssignmentsAction))]
    public partial interface IBusinessUnitSetCustomerGroupAssignmentsAction : IBusinessUnitUpdateAction
    {
        IList<ICustomerGroupAssignmentDraft> CustomerGroupAssignments { get; set; }

        IEnumerable<ICustomerGroupAssignmentDraft> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }

    }
}
