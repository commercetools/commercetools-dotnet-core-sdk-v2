using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessage))]
    public partial interface IApprovalFlowCreatedMessage : IMessage
    {
        IApprovalFlow ApprovalFlow { get; set; }

    }
}
