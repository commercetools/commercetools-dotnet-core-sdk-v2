using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentsSetMessagePayload))]
    public partial interface ICustomerGroupAssignmentsSetMessagePayload : IMessagePayload
    {
        IList<ICustomerGroupAssignment> CustomerGroupAssignments { get; set; }

        IEnumerable<ICustomerGroupAssignment> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }

    }
}
