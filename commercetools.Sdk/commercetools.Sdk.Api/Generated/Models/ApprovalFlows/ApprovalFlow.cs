using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlow : IApprovalFlow
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public IOrderReference Order { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IList<IApprovalRule> Rules { get; set; }
        public IEnumerable<IApprovalRule> RulesEnumerable { set => Rules = value.ToList(); }


        public IApprovalFlowStatus Status { get; set; }

        public IApprovalFlowRejection Rejection { get; set; }

        public IList<IApprovalFlowApproval> Approvals { get; set; }
        public IEnumerable<IApprovalFlowApproval> ApprovalsEnumerable { set => Approvals = value.ToList(); }


        public IList<IRuleApprover> EligibleApprovers { get; set; }
        public IEnumerable<IRuleApprover> EligibleApproversEnumerable { set => EligibleApprovers = value.ToList(); }


        public IList<IRuleApprover> PendingApprovers { get; set; }
        public IEnumerable<IRuleApprover> PendingApproversEnumerable { set => PendingApprovers = value.ToList(); }


        public IList<IRuleApprover> CurrentTierPendingApprovers { get; set; }
        public IEnumerable<IRuleApprover> CurrentTierPendingApproversEnumerable { set => CurrentTierPendingApprovers = value.ToList(); }

    }
}
