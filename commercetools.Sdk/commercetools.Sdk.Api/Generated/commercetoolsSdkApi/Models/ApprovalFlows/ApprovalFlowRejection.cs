using commercetools.Sdk.Api.Models.BusinessUnits;
using System;

namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowRejection : IApprovalFlowRejection
    {
        public IAssociate Rejecter { get; set; }

        public DateTime RejectedAt { get; set; }

        public string Reason { get; set; }
    }
}
