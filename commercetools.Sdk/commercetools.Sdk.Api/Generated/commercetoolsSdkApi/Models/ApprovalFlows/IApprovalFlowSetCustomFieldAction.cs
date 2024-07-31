using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction))]
    public partial interface IApprovalFlowSetCustomFieldAction : IApprovalFlowUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
