using commercetools.Sdk.Api.Models.BusinessUnits;
using System;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowApproval : IApprovalFlowApproval
    {
        public IAssociate Approver { get; set; }

        public DateTime ApprovedAt { get; set; }
    }
}
