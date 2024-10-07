using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction))]
    public partial interface IApprovalFlowRejectAction : IApprovalFlowUpdateAction
    {
        string Reason { get; set; }

    }
}
