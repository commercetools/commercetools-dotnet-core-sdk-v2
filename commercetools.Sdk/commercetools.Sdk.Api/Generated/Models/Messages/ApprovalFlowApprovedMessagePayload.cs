using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowApprovedMessagePayload : IApprovalFlowApprovedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Associate { get; set; }

        public IOrderReference Order { get; set; }
        public ApprovalFlowApprovedMessagePayload()
        {
            this.Type = "ApprovalFlowApproved";
        }
    }
}
