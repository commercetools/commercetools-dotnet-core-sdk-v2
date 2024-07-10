using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowRejectedMessagePayload : IApprovalFlowRejectedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Associate { get; set; }

        public string RejectionReason { get; set; }

        public IOrderReference Order { get; set; }
        public ApprovalFlowRejectedMessagePayload()
        {
            this.Type = "ApprovalFlowRejected";
        }
    }
}
