using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleStatusSetMessagePayload))]
    public partial interface IApprovalRuleStatusSetMessagePayload : IMessagePayload
    {
        IApprovalRuleStatus Status { get; set; }

        IApprovalRuleStatus OldStatus { get; set; }

    }
}
