using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
