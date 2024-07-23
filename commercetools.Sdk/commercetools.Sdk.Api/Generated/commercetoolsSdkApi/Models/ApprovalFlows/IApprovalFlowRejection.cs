using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejection))]
    public partial interface IApprovalFlowRejection
    {
        IAssociate Rejecter { get; set; }

        DateTime RejectedAt { get; set; }

        string Reason { get; set; }

    }
}
