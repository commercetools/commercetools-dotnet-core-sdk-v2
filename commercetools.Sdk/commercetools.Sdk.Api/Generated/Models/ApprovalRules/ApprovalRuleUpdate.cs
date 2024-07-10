using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleUpdate : IApprovalRuleUpdate
    {
        public long Version { get; set; }

        public IList<IApprovalRuleUpdateAction> Actions { get; set; }
        public IEnumerable<IApprovalRuleUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
