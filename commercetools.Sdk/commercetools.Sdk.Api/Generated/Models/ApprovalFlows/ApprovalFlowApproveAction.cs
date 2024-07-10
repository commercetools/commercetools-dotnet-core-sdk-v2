using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowApproveAction : IApprovalFlowApproveAction
    {
        public string Action { get; set; }
        public ApprovalFlowApproveAction()
        {
            this.Action = "approve";
        }
    }
}
