using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessagePayload))]
    public partial interface IBusinessUnitApprovalRuleModeChangedMessagePayload : IMessagePayload
    {
        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        IBusinessUnitApprovalRuleMode OldApprovalRuleMode { get; set; }

    }
}
