using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupAssignmentRemovedMessagePayload : ICustomerGroupAssignmentRemovedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupAssignment CustomerGroupAssignment { get; set; }
        public CustomerGroupAssignmentRemovedMessagePayload()
        {
            this.Type = "CustomerGroupAssignmentRemoved";
        }
    }
}
