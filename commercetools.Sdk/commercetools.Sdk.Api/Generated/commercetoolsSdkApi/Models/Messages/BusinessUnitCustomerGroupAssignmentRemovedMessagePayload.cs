using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentRemovedMessagePayload : IBusinessUnitCustomerGroupAssignmentRemovedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupAssignment CustomerGroupAssignment { get; set; }
        public BusinessUnitCustomerGroupAssignmentRemovedMessagePayload()
        {
            this.Type = "BusinessUnitCustomerGroupAssignmentRemoved";
        }
    }
}
