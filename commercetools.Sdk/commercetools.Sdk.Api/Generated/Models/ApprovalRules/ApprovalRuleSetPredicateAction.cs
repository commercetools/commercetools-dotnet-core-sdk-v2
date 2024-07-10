using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetPredicateAction : IApprovalRuleSetPredicateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public ApprovalRuleSetPredicateAction()
        {
            this.Action = "setPredicate";
        }
    }
}
