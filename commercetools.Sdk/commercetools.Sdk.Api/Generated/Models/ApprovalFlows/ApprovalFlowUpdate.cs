using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowUpdate : IApprovalFlowUpdate
    {
        public long Version { get; set; }

        public IList<IApprovalFlowUpdateAction> Actions { get; set; }
        public IEnumerable<IApprovalFlowUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
