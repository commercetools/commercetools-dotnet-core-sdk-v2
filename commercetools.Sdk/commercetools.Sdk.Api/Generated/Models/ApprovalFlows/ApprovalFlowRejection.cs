using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowRejection : IApprovalFlowRejection
    {
        public IAssociate Rejecter { get; set; }

        public DateTime RejectedAt { get; set; }

        public string Reason { get; set; }
    }
}
