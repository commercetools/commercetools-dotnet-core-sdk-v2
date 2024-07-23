using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRule : IApprovalRule
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IApprovalRuleStatus Status { get; set; }

        public string Predicate { get; set; }

        public IApproverHierarchy Approvers { get; set; }

        public IList<IRuleRequester> Requesters { get; set; }
        public IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }


        public IBusinessUnitKeyReference BusinessUnit { get; set; }
    }
}
