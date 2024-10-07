using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
