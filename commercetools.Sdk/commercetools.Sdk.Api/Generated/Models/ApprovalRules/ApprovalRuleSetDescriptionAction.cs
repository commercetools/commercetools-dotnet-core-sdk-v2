using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetDescriptionAction : IApprovalRuleSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ApprovalRuleSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
