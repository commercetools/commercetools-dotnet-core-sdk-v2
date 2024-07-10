using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRulePredicateSetMessagePayload : IApprovalRulePredicateSetMessagePayload
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public string OldPredicate { get; set; }
        public ApprovalRulePredicateSetMessagePayload()
        {
            this.Type = "ApprovalRulePredicateSet";
        }
    }
}
