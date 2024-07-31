using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessagePayload))]
    public partial interface IApprovalRuleNameSetMessagePayload : IMessagePayload
    {
        string Name { get; set; }

        string OldName { get; set; }

    }
}
