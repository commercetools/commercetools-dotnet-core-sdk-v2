using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowApproval : IApprovalFlowApproval
    {
        public IAssociate Approver { get; set; }

        public DateTime ApprovedAt { get; set; }
    }
}
