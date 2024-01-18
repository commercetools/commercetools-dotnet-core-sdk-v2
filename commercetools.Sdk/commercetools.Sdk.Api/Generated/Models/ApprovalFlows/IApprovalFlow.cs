using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlow))]
    public partial interface IApprovalFlow : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        ICreatedBy CreatedBy { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        IOrderReference Order { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IList<IApprovalRule> Rules { get; set; }
        IEnumerable<IApprovalRule> RulesEnumerable { set => Rules = value.ToList(); }


        IApprovalFlowStatus Status { get; set; }

        IApprovalFlowRejection Rejection { get; set; }

        IList<IApprovalFlowApproval> Approvals { get; set; }
        IEnumerable<IApprovalFlowApproval> ApprovalsEnumerable { set => Approvals = value.ToList(); }


        IList<IRuleApprover> EligibleApprovers { get; set; }
        IEnumerable<IRuleApprover> EligibleApproversEnumerable { set => EligibleApprovers = value.ToList(); }


        IList<IRuleApprover> PendingApprovers { get; set; }
        IEnumerable<IRuleApprover> PendingApproversEnumerable { set => PendingApprovers = value.ToList(); }


        IList<IRuleApprover> CurrentTierPendingApprovers { get; set; }
        IEnumerable<IRuleApprover> CurrentTierPendingApproversEnumerable { set => CurrentTierPendingApprovers = value.ToList(); }


    }
}
