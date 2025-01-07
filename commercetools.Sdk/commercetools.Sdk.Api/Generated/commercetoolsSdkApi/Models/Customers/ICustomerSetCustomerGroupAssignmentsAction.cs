using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAssignmentsAction))]
    public partial interface ICustomerSetCustomerGroupAssignmentsAction : ICustomerUpdateAction
    {
        IList<ICustomerGroupAssignmentDraft> CustomerGroupAssignments { get; set; }

        IEnumerable<ICustomerGroupAssignmentDraft> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }

    }
}
