using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddCustomerGroupAssignmentAction : IBusinessUnitAddCustomerGroupAssignmentAction
    {
        public string Action { get; set; }

        public ICustomerGroupAssignmentDraft CustomerGroupAssignment { get; set; }
        public BusinessUnitAddCustomerGroupAssignmentAction()
        {
            this.Action = "addCustomerGroupAssignment";
        }
    }
}
