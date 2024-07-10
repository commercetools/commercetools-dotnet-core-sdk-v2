using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowRejectAction : IApprovalFlowRejectAction
    {
        public string Action { get; set; }

        public string Reason { get; set; }
        public ApprovalFlowRejectAction()
        {
            this.Action = "reject";
        }
    }
}
