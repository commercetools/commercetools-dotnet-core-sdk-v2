using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddCustomerGroupAssignmentAction))]
    public partial interface ICustomerAddCustomerGroupAssignmentAction : ICustomerUpdateAction
    {
        ICustomerGroupAssignmentDraft CustomerGroupAssignment { get; set; }

    }
}
