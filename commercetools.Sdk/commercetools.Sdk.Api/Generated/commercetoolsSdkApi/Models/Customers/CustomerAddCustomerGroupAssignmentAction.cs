

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerAddCustomerGroupAssignmentAction : ICustomerAddCustomerGroupAssignmentAction
    {
        public string Action { get; set; }

        public ICustomerGroupAssignmentDraft CustomerGroupAssignment { get; set; }
        public CustomerAddCustomerGroupAssignmentAction()
        {
            this.Action = "addCustomerGroupAssignment";
        }
    }
}
