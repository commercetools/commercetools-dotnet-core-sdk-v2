using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddCustomerGroupAssignmentAction))]
    public partial interface IBusinessUnitAddCustomerGroupAssignmentAction : IBusinessUnitUpdateAction
    {
        ICustomerGroupAssignmentDraft CustomerGroupAssignment { get; set; }

    }
}
