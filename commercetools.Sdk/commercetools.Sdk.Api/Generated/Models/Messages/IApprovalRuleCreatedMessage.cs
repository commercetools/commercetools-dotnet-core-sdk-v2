using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleCreatedMessage))]
    public partial interface IApprovalRuleCreatedMessage : IMessage
    {
        IApprovalRule ApprovalRule { get; set; }

    }
}
