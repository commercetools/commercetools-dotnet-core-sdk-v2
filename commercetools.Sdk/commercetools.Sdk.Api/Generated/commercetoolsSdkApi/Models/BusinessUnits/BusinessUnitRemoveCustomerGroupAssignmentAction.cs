using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveCustomerGroupAssignmentAction : IBusinessUnitRemoveCustomerGroupAssignmentAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public BusinessUnitRemoveCustomerGroupAssignmentAction()
        {
            this.Action = "removeCustomerGroupAssignment";
        }
    }
}
