using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupAssignmentAddedMessagePayload : ICustomerGroupAssignmentAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupAssignment CustomerGroupAssignment { get; set; }
        public CustomerGroupAssignmentAddedMessagePayload()
        {
            this.Type = "CustomerGroupAssignmentAdded";
        }
    }
}
