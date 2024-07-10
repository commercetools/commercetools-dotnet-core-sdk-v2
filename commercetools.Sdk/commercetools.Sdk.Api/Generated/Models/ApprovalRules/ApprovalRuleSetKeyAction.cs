using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetKeyAction : IApprovalRuleSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ApprovalRuleSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
