using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproval))]
    public partial interface IApprovalFlowApproval
    {
        IAssociate Approver { get; set; }

        DateTime ApprovedAt { get; set; }

    }
}
