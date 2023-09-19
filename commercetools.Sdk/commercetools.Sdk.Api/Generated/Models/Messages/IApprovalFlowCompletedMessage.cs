using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessage))]
    public partial interface IApprovalFlowCompletedMessage : IMessage
    {
        IApprovalFlowStatus Status { get; set; }

        IOrderReference Order { get; set; }

    }
}
