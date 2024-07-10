using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleCreatedMessagePayload : IApprovalRuleCreatedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalRule ApprovalRule { get; set; }
        public ApprovalRuleCreatedMessagePayload()
        {
            this.Type = "ApprovalRuleCreated";
        }
    }
}
