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

    public partial class ApprovalRuleStatusSetMessagePayload : IApprovalRuleStatusSetMessagePayload
    {
        public string Type { get; set; }

        public IApprovalRuleStatus Status { get; set; }

        public IApprovalRuleStatus OldStatus { get; set; }
        public ApprovalRuleStatusSetMessagePayload()
        {
            this.Type = "ApprovalRuleStatusSet";
        }
    }
}
