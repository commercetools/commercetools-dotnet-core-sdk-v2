using commercetools.Sdk.Api.Models.BusinessUnits;


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
