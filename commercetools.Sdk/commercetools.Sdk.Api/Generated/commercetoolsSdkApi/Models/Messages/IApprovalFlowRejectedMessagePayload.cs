using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessagePayload))]
    public partial interface IApprovalFlowRejectedMessagePayload : IMessagePayload
    {
        ICustomerReference Associate { get; set; }

        string RejectionReason { get; set; }

        IOrderReference Order { get; set; }

    }
}
