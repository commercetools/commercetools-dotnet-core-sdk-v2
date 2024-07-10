using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitApprovalRuleModeChangedMessagePayload : IBusinessUnitApprovalRuleModeChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        public IBusinessUnitApprovalRuleMode OldApprovalRuleMode { get; set; }
        public BusinessUnitApprovalRuleModeChangedMessagePayload()
        {
            this.Type = "BusinessUnitApprovalRuleModeChanged";
        }
    }
}
