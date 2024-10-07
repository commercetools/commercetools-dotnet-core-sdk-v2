using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage))]
    public partial interface IBusinessUnitApprovalRuleModeChangedMessage : IMessage
    {
        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        IBusinessUnitApprovalRuleMode OldApprovalRuleMode { get; set; }

    }
}
