using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerRemoveCustomerGroupAssignmentAction : ICustomerRemoveCustomerGroupAssignmentAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public CustomerRemoveCustomerGroupAssignmentAction()
        {
            this.Action = "removeCustomerGroupAssignment";
        }
    }
}
