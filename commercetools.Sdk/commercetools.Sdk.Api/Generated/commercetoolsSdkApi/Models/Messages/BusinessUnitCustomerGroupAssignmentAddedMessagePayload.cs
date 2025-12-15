using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentAddedMessagePayload : IBusinessUnitCustomerGroupAssignmentAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupAssignment CustomerGroupAssignment { get; set; }
        public BusinessUnitCustomerGroupAssignmentAddedMessagePayload()
        {
            this.Type = "BusinessUnitCustomerGroupAssignmentAdded";
        }
    }
}
