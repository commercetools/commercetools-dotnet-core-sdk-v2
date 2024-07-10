using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessagePayload))]
    public partial interface IApprovalRuleCreatedMessagePayload : IMessagePayload
    {
        IApprovalRule ApprovalRule { get; set; }

    }
}
