using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCreatedMessagePayload))]
    public partial interface IApprovalFlowCreatedMessagePayload : IMessagePayload
    {
        IApprovalFlow ApprovalFlow { get; set; }

    }
}
