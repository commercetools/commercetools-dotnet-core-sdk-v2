using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessage))]
    public partial interface IApprovalRuleDescriptionSetMessage : IMessage
    {
        string Description { get; set; }

        string OldDescription { get; set; }

    }
}
