using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupAssignmentRemovedMessagePayload : ICustomerGroupAssignmentRemovedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupReference CustomerGroupAssignment { get; set; }
        public CustomerGroupAssignmentRemovedMessagePayload()
        {
            this.Type = "CustomerGroupAssignmentRemoved";
        }
    }
}
