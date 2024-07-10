using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowUpdate))]
    public partial interface IApprovalFlowUpdate
    {
        long Version { get; set; }

        IList<IApprovalFlowUpdateAction> Actions { get; set; }
        IEnumerable<IApprovalFlowUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
